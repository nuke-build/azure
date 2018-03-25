﻿// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure-cli/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Azure.Generator.Model;
using Nuke.Common;
using Nuke.Core.Utilities.Collections;
using YamlDotNet.Serialization;

namespace Nuke.Azure.Generator
{
    internal static class DefinitionLoader
    {
        private const string c_definitionFileExtension = ".yml";
        private const string c_tocFileName = "TOC.yml";
        private const string c_referenceUrl = "https://raw.githubusercontent.com/Azure/azure-docs-cli-python/{0}/latest/docs-ref-autogen/";

        public static IEnumerable<TableOfContentsEntry> LoadTablesOfContent(string definitonsPath)
        {
            var tocPath = Path.Combine(definitonsPath, c_tocFileName);
            ControlFlow.Assert(File.Exists(tocPath), $"Could not load TOC at '${tocPath}.'");
            var tocContent = File.ReadAllText(tocPath);
            var tocObject = new Deserializer().Deserialize<object>(tocContent);
            var tocs = JsonConvert.DeserializeObject<TableOfContentsEntry[]>(JsonConvert.SerializeObject(tocObject));
            tocs.ForEach(x => PoupuateTocInformation(x, parent: null, depth: out _, commands: out _));
            return tocs;
        }

        public static List<Definiton> LoadCommandDefinitons(string path, string reference)
        {
            path = path.Replace(oldChar: '\\', newChar: '/');
            path = path.EndsWith("/") ? path : path + '/';
            var files = Directory.EnumerateFiles(path, $"*{c_definitionFileExtension}", SearchOption.AllDirectories).ToList();
            var definitions = new List<Definiton>();

            foreach (var file in files)
            {
                if (file == path + c_tocFileName) continue;
                var fileContent = File.ReadAllText(file);

                var definition = ParseDefinition(fileContent);
                PopulateDefinitionInfos(definition,
                    string.Format(c_referenceUrl, reference) + file.Replace(oldChar: '\\', newChar: '/').Replace(path, string.Empty));
                definitions.Add(definition);
            }

            return definitions;
        }

        private static Definiton ParseDefinition(string definitionYaml)
        {
            var yamlObject = new Deserializer().Deserialize<object>(definitionYaml);
            var json = JsonConvert.SerializeObject(yamlObject);

            var definiton = JsonConvert.DeserializeObject<Definiton>(json);
            return definiton;
        }

        private static void PopulateDefinitionInfos(Definiton defintion, string referencePath)
        {
            defintion.ReferenceUrl = referencePath;
            foreach (var defintionItem in defintion.Items) PopulateDefinitionInfos(defintionItem, defintion, referencePath);

            foreach (var defintionGlobalParameter in defintion.GlobalParameters) defintionGlobalParameter.Parent = defintion;
        }

        private static void PopulateDefinitionInfos(Item item, IDefinition parent, string referencePath)
        {
            item.ReferencePath = referencePath;
            item.Parent = parent;
            foreach (var itemParameter in item.Parameters) itemParameter.Parent = item;

            foreach (var itemItem in item.Items) PopulateDefinitionInfos(itemItem, item, referencePath);
        }

        private static void PoupuateTocInformation(TableOfContentsEntry toc, [CanBeNull] TableOfContentsEntry parent, out int depth, out int commands)
        {
            commands = toc.HasItems && toc.Items.All(x => x.HasItems) ? 0 : 1;
            depth = 0;

            foreach (var tableOfContentsEntry in toc.Items)
            {
                PoupuateTocInformation(tableOfContentsEntry, toc, out var depthResult, out var commandResult);
                if (depthResult > depth) depth = depthResult;
                commands += commandResult;
            }

            if (toc.HasItems) depth++;
            toc.Parent = parent;
            toc.TotalCommandsInTable = commands;
            toc.Depth = depth;
        }
    }
}
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureDisk.json
// Generated with Nuke.CodeGeneration version 0.20.1 (OSX,.NETStandard,Version=v2.0)

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Azure
{
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskTasks
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public static string AzureDiskPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREDISK_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureDiskLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Managed Disks.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDisk(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureDiskPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureDiskLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskCreate(AzureDiskCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskCreateSettings.Debug"/></li>
        ///     <li><c>--disk-iops-read-write</c> via <see cref="AzureDiskCreateSettings.DiskIopsReadWrite"/></li>
        ///     <li><c>--disk-mbps-read-write</c> via <see cref="AzureDiskCreateSettings.DiskMbpsReadWrite"/></li>
        ///     <li><c>--for-upload</c> via <see cref="AzureDiskCreateSettings.ForUpload"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v-generation</c> via <see cref="AzureDiskCreateSettings.HyperVGeneration"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDiskCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDiskCreateSettings.NoWait"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureDiskCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--size-gb</c> via <see cref="AzureDiskCreateSettings.SizeGb"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureDiskCreateSettings.Sku"/></li>
        ///     <li><c>--source</c> via <see cref="AzureDiskCreateSettings.Source"/></li>
        ///     <li><c>--source-storage-account-id</c> via <see cref="AzureDiskCreateSettings.SourceStorageAccountId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDiskCreateSettings.Tags"/></li>
        ///     <li><c>--upload-size-bytes</c> via <see cref="AzureDiskCreateSettings.UploadSizeBytes"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskCreateSettings.Verbose"/></li>
        ///     <li><c>--zone</c> via <see cref="AzureDiskCreateSettings.Zone"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskCreate(Configure<AzureDiskCreateSettings> configurator)
        {
            return AzureDiskCreate(configurator(new AzureDiskCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskCreateSettings.Debug"/></li>
        ///     <li><c>--disk-iops-read-write</c> via <see cref="AzureDiskCreateSettings.DiskIopsReadWrite"/></li>
        ///     <li><c>--disk-mbps-read-write</c> via <see cref="AzureDiskCreateSettings.DiskMbpsReadWrite"/></li>
        ///     <li><c>--for-upload</c> via <see cref="AzureDiskCreateSettings.ForUpload"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v-generation</c> via <see cref="AzureDiskCreateSettings.HyperVGeneration"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDiskCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDiskCreateSettings.NoWait"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureDiskCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--size-gb</c> via <see cref="AzureDiskCreateSettings.SizeGb"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureDiskCreateSettings.Sku"/></li>
        ///     <li><c>--source</c> via <see cref="AzureDiskCreateSettings.Source"/></li>
        ///     <li><c>--source-storage-account-id</c> via <see cref="AzureDiskCreateSettings.SourceStorageAccountId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDiskCreateSettings.Tags"/></li>
        ///     <li><c>--upload-size-bytes</c> via <see cref="AzureDiskCreateSettings.UploadSizeBytes"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskCreateSettings.Verbose"/></li>
        ///     <li><c>--zone</c> via <see cref="AzureDiskCreateSettings.Zone"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskCreate(CombinatorialConfigure<AzureDiskCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskCreate, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskDelete(AzureDiskDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDiskDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDiskDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskDelete(Configure<AzureDiskDeleteSettings> configurator)
        {
            return AzureDiskDelete(configurator(new AzureDiskDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDiskDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDiskDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskDelete(CombinatorialConfigure<AzureDiskDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskDelete, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskGrantAccess(AzureDiskGrantAccessSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskGrantAccessSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--access-level</c> via <see cref="AzureDiskGrantAccessSettings.AccessLevel"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDiskGrantAccessSettings.Debug"/></li>
        ///     <li><c>--duration-in-seconds</c> via <see cref="AzureDiskGrantAccessSettings.DurationInSeconds"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskGrantAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskGrantAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskGrantAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskGrantAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskGrantAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskGrantAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskGrantAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskGrantAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskGrantAccess(Configure<AzureDiskGrantAccessSettings> configurator)
        {
            return AzureDiskGrantAccess(configurator(new AzureDiskGrantAccessSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--access-level</c> via <see cref="AzureDiskGrantAccessSettings.AccessLevel"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDiskGrantAccessSettings.Debug"/></li>
        ///     <li><c>--duration-in-seconds</c> via <see cref="AzureDiskGrantAccessSettings.DurationInSeconds"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskGrantAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskGrantAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskGrantAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskGrantAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskGrantAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskGrantAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskGrantAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskGrantAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskGrantAccessSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskGrantAccess(CombinatorialConfigure<AzureDiskGrantAccessSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskGrantAccess, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskList(AzureDiskListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskList(Configure<AzureDiskListSettings> configurator)
        {
            return AzureDiskList(configurator(new AzureDiskListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskListSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskList(CombinatorialConfigure<AzureDiskListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskList, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskRevokeAccess(AzureDiskRevokeAccessSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskRevokeAccessSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskRevokeAccessSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskRevokeAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskRevokeAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskRevokeAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskRevokeAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskRevokeAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskRevokeAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskRevokeAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskRevokeAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskRevokeAccess(Configure<AzureDiskRevokeAccessSettings> configurator)
        {
            return AzureDiskRevokeAccess(configurator(new AzureDiskRevokeAccessSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskRevokeAccessSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskRevokeAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskRevokeAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskRevokeAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskRevokeAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskRevokeAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskRevokeAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskRevokeAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskRevokeAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskRevokeAccessSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskRevokeAccess(CombinatorialConfigure<AzureDiskRevokeAccessSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskRevokeAccess, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskShow(AzureDiskShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskShow(Configure<AzureDiskShowSettings> configurator)
        {
            return AzureDiskShow(configurator(new AzureDiskShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDiskShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskShow(CombinatorialConfigure<AzureDiskShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskShow, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskUpdate(AzureDiskUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDiskUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDiskUpdateSettings.Debug"/></li>
        ///     <li><c>--disk-iops-read-write</c> via <see cref="AzureDiskUpdateSettings.DiskIopsReadWrite"/></li>
        ///     <li><c>--disk-mbps-read-write</c> via <see cref="AzureDiskUpdateSettings.DiskMbpsReadWrite"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDiskUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDiskUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDiskUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDiskUpdateSettings.Set"/></li>
        ///     <li><c>--size-gb</c> via <see cref="AzureDiskUpdateSettings.SizeGb"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureDiskUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskUpdate(Configure<AzureDiskUpdateSettings> configurator)
        {
            return AzureDiskUpdate(configurator(new AzureDiskUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDiskUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDiskUpdateSettings.Debug"/></li>
        ///     <li><c>--disk-iops-read-write</c> via <see cref="AzureDiskUpdateSettings.DiskIopsReadWrite"/></li>
        ///     <li><c>--disk-mbps-read-write</c> via <see cref="AzureDiskUpdateSettings.DiskMbpsReadWrite"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDiskUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDiskUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDiskUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDiskUpdateSettings.Set"/></li>
        ///     <li><c>--size-gb</c> via <see cref="AzureDiskUpdateSettings.SizeGb"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureDiskUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskUpdate(CombinatorialConfigure<AzureDiskUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskUpdate, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDiskWait(AzureDiskWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDiskWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureDiskWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureDiskWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDiskWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureDiskWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureDiskWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureDiskWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureDiskWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureDiskWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDiskWait(Configure<AzureDiskWaitSettings> configurator)
        {
            return AzureDiskWait(configurator(new AzureDiskWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Managed Disks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/disk?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureDiskWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureDiskWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDiskWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureDiskWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureDiskWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDiskWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureDiskWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureDiskWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDiskWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDiskWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDiskWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDiskWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDiskWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureDiskWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureDiskWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDiskWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDiskWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureDiskWait(CombinatorialConfigure<AzureDiskWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDiskWait, AzureDiskLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureDiskCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        public virtual string DiskIopsReadWrite { get; internal set; }
        /// <summary>
        ///   The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.
        /// </summary>
        public virtual string DiskMbpsReadWrite { get; internal set; }
        /// <summary>
        ///   Create the disk for uploading blobs later on through storage commands. Run "az disk grant-access --access-level Write" to retrieve the disk's SAS token.
        /// </summary>
        public virtual bool? ForUpload { get; internal set; }
        /// <summary>
        ///   The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        /// </summary>
        public virtual DiskCreateHyperVGeneration HyperVGeneration { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The Operating System type of the Disk.
        /// </summary>
        public virtual DiskCreateOsType OsType { get; internal set; }
        /// <summary>
        ///   Size in GB. Max size: 4095 GB (certain preview disks can be larger).
        /// </summary>
        public virtual string SizeGb { get; internal set; }
        /// <summary>
        ///   Underlying storage SKU.
        /// </summary>
        public virtual DiskSku Sku { get; internal set; }
        /// <summary>
        ///   Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.
        /// </summary>
        public virtual string Source { get; internal set; }
        /// <summary>
        ///   Used when source blob is in a different subscription.
        /// </summary>
        public virtual string SourceStorageAccountId { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The size (in bytes) of the contents of the upload including the VHD footer. Min value: 20972032. Max value: 35183298347520.
        /// </summary>
        public virtual string UploadSizeBytes { get; internal set; }
        /// <summary>
        ///   Availability zone into which to provision the resource.
        /// </summary>
        public virtual DiskCreateZone Zone { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disk-iops-read-write {value}", DiskIopsReadWrite)
              .Add("--disk-mbps-read-write {value}", DiskMbpsReadWrite)
              .Add("--for-upload", ForUpload)
              .Add("--hyper-v-generation {value}", HyperVGeneration)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--os-type {value}", OsType)
              .Add("--size-gb {value}", SizeGb)
              .Add("--sku {value}", Sku)
              .Add("--source {value}", Source)
              .Add("--source-storage-account-id {value}", SourceStorageAccountId)
              .Add("--tags {value}", Tags)
              .Add("--upload-size-bytes {value}", UploadSizeBytes)
              .Add("--zone {value}", Zone)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk delete")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskGrantAccessSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskGrantAccessSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   Time duration in seconds until the SAS access expires.
        /// </summary>
        public virtual string DurationInSeconds { get; internal set; }
        /// <summary>
        ///   Access level.
        /// </summary>
        public virtual DiskGrantAccessAccessLevel AccessLevel { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk grant-access")
              .Add("--duration-in-seconds {value}", DurationInSeconds)
              .Add("--access-level {value}", AccessLevel)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskListSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskRevokeAccessSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskRevokeAccessSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk revoke-access")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        public virtual string DiskIopsReadWrite { get; internal set; }
        /// <summary>
        ///   The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.
        /// </summary>
        public virtual string DiskMbpsReadWrite { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Size in GB. Max size: 4095 GB (certain preview disks can be larger).
        /// </summary>
        public virtual string SizeGb { get; internal set; }
        /// <summary>
        ///   Underlying storage SKU.
        /// </summary>
        public virtual DiskSku Sku { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.
        /// </summary>
        public virtual string Add { get; internal set; }
        /// <summary>
        ///   When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public virtual string ForceString { get; internal set; }
        /// <summary>
        ///   Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.
        /// </summary>
        public virtual string Remove { get; internal set; }
        /// <summary>
        ///   Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.
        /// </summary>
        public virtual string Set { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk update")
              .Add("--disk-iops-read-write {value}", DiskIopsReadWrite)
              .Add("--disk-mbps-read-write {value}", DiskMbpsReadWrite)
              .Add("--no-wait", NoWait)
              .Add("--size-gb {value}", SizeGb)
              .Add("--sku {value}", Sku)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDiskWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDisk executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDiskTasks.AzureDiskPath;
        public override Action<OutputType, string> CustomLogger => AzureDiskTasks.AzureDiskLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed disk.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
        /// <summary>
        ///   Wait until the resource exists.
        /// </summary>
        public virtual string Exists { get; internal set; }
        /// <summary>
        ///   Polling interval in seconds.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Maximum wait in seconds.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("disk wait")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDiskCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetName(this AzureDiskCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetName(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetResourceGroup(this AzureDiskCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetResourceGroup(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DiskIopsReadWrite
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.DiskIopsReadWrite"/></em></p>
        ///   <p>The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetDiskIopsReadWrite(this AzureDiskCreateSettings toolSettings, string diskIopsReadWrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskIopsReadWrite = diskIopsReadWrite;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.DiskIopsReadWrite"/></em></p>
        ///   <p>The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetDiskIopsReadWrite(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskIopsReadWrite = null;
            return toolSettings;
        }
        #endregion
        #region DiskMbpsReadWrite
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.DiskMbpsReadWrite"/></em></p>
        ///   <p>The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetDiskMbpsReadWrite(this AzureDiskCreateSettings toolSettings, string diskMbpsReadWrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskMbpsReadWrite = diskMbpsReadWrite;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.DiskMbpsReadWrite"/></em></p>
        ///   <p>The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetDiskMbpsReadWrite(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskMbpsReadWrite = null;
            return toolSettings;
        }
        #endregion
        #region ForUpload
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the disk for uploading blobs later on through storage commands. Run "az disk grant-access --access-level Write" to retrieve the disk's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetForUpload(this AzureDiskCreateSettings toolSettings, bool? forUpload)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = forUpload;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the disk for uploading blobs later on through storage commands. Run "az disk grant-access --access-level Write" to retrieve the disk's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetForUpload(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDiskCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the disk for uploading blobs later on through storage commands. Run "az disk grant-access --access-level Write" to retrieve the disk's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings EnableForUpload(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDiskCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the disk for uploading blobs later on through storage commands. Run "az disk grant-access --access-level Write" to retrieve the disk's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings DisableForUpload(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDiskCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the disk for uploading blobs later on through storage commands. Run "az disk grant-access --access-level Write" to retrieve the disk's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ToggleForUpload(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = !toolSettings.ForUpload;
            return toolSettings;
        }
        #endregion
        #region HyperVGeneration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.HyperVGeneration"/></em></p>
        ///   <p>The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetHyperVGeneration(this AzureDiskCreateSettings toolSettings, DiskCreateHyperVGeneration hyperVGeneration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperVGeneration = hyperVGeneration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.HyperVGeneration"/></em></p>
        ///   <p>The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetHyperVGeneration(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperVGeneration = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetLocation(this AzureDiskCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetLocation(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetNoWait(this AzureDiskCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetNoWait(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDiskCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings EnableNoWait(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDiskCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings DisableNoWait(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDiskCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ToggleNoWait(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.OsType"/></em></p>
        ///   <p>The Operating System type of the Disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetOsType(this AzureDiskCreateSettings toolSettings, DiskCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.OsType"/></em></p>
        ///   <p>The Operating System type of the Disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetOsType(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region SizeGb
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.SizeGb"/></em></p>
        ///   <p>Size in GB. Max size: 4095 GB (certain preview disks can be larger).</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetSizeGb(this AzureDiskCreateSettings toolSettings, string sizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = sizeGb;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.SizeGb"/></em></p>
        ///   <p>Size in GB. Max size: 4095 GB (certain preview disks can be larger).</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetSizeGb(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Sku"/></em></p>
        ///   <p>Underlying storage SKU.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetSku(this AzureDiskCreateSettings toolSettings, DiskSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Sku"/></em></p>
        ///   <p>Underlying storage SKU.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetSku(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Source"/></em></p>
        ///   <p>Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetSource(this AzureDiskCreateSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Source"/></em></p>
        ///   <p>Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetSource(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region SourceStorageAccountId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.SourceStorageAccountId"/></em></p>
        ///   <p>Used when source blob is in a different subscription.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetSourceStorageAccountId(this AzureDiskCreateSettings toolSettings, string sourceStorageAccountId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceStorageAccountId = sourceStorageAccountId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.SourceStorageAccountId"/></em></p>
        ///   <p>Used when source blob is in a different subscription.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetSourceStorageAccountId(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceStorageAccountId = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetTags(this AzureDiskCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetTags(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region UploadSizeBytes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.UploadSizeBytes"/></em></p>
        ///   <p>The size (in bytes) of the contents of the upload including the VHD footer. Min value: 20972032. Max value: 35183298347520.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetUploadSizeBytes(this AzureDiskCreateSettings toolSettings, string uploadSizeBytes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UploadSizeBytes = uploadSizeBytes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.UploadSizeBytes"/></em></p>
        ///   <p>The size (in bytes) of the contents of the upload including the VHD footer. Min value: 20972032. Max value: 35183298347520.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetUploadSizeBytes(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UploadSizeBytes = null;
            return toolSettings;
        }
        #endregion
        #region Zone
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Zone"/></em></p>
        ///   <p>Availability zone into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetZone(this AzureDiskCreateSettings toolSettings, DiskCreateZone zone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Zone = zone;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Zone"/></em></p>
        ///   <p>Availability zone into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetZone(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Zone = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetSubscription(this AzureDiskCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetSubscription(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetDebug(this AzureDiskCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetDebug(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetHelp(this AzureDiskCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetHelp(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetOutput(this AzureDiskCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetOutput(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetQuery(this AzureDiskCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetQuery(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings SetVerbose(this AzureDiskCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskCreateSettings ResetVerbose(this AzureDiskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetNoWait(this AzureDiskDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetNoWait(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDiskDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings EnableNoWait(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDiskDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings DisableNoWait(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDiskDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ToggleNoWait(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetYes(this AzureDiskDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetYes(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetIds(this AzureDiskDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetIds(this AzureDiskDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings AddIds(this AzureDiskDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings AddIds(this AzureDiskDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureDiskDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ClearIds(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings RemoveIds(this AzureDiskDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings RemoveIds(this AzureDiskDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetName(this AzureDiskDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetName(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetResourceGroup(this AzureDiskDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetResourceGroup(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetSubscription(this AzureDiskDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetSubscription(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetDebug(this AzureDiskDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetDebug(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetHelp(this AzureDiskDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetHelp(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetOutput(this AzureDiskDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetOutput(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetQuery(this AzureDiskDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetQuery(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings SetVerbose(this AzureDiskDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskDeleteSettings ResetVerbose(this AzureDiskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskGrantAccessSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskGrantAccessSettingsExtensions
    {
        #region DurationInSeconds
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.DurationInSeconds"/></em></p>
        ///   <p>Time duration in seconds until the SAS access expires.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetDurationInSeconds(this AzureDiskGrantAccessSettings toolSettings, string durationInSeconds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurationInSeconds = durationInSeconds;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.DurationInSeconds"/></em></p>
        ///   <p>Time duration in seconds until the SAS access expires.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetDurationInSeconds(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurationInSeconds = null;
            return toolSettings;
        }
        #endregion
        #region AccessLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.AccessLevel"/></em></p>
        ///   <p>Access level.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetAccessLevel(this AzureDiskGrantAccessSettings toolSettings, DiskGrantAccessAccessLevel accessLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessLevel = accessLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.AccessLevel"/></em></p>
        ///   <p>Access level.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetAccessLevel(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessLevel = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetIds(this AzureDiskGrantAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetIds(this AzureDiskGrantAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings AddIds(this AzureDiskGrantAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings AddIds(this AzureDiskGrantAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureDiskGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ClearIds(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings RemoveIds(this AzureDiskGrantAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings RemoveIds(this AzureDiskGrantAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetName(this AzureDiskGrantAccessSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetName(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetResourceGroup(this AzureDiskGrantAccessSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetResourceGroup(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetSubscription(this AzureDiskGrantAccessSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetSubscription(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetDebug(this AzureDiskGrantAccessSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetDebug(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetHelp(this AzureDiskGrantAccessSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetHelp(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetOutput(this AzureDiskGrantAccessSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetOutput(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetQuery(this AzureDiskGrantAccessSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetQuery(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskGrantAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings SetVerbose(this AzureDiskGrantAccessSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskGrantAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskGrantAccessSettings ResetVerbose(this AzureDiskGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetResourceGroup(this AzureDiskListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetResourceGroup(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetSubscription(this AzureDiskListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetSubscription(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetDebug(this AzureDiskListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetDebug(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetHelp(this AzureDiskListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetHelp(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetOutput(this AzureDiskListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetOutput(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetQuery(this AzureDiskListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetQuery(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings SetVerbose(this AzureDiskListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskListSettings ResetVerbose(this AzureDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskRevokeAccessSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskRevokeAccessSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetIds(this AzureDiskRevokeAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetIds(this AzureDiskRevokeAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings AddIds(this AzureDiskRevokeAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings AddIds(this AzureDiskRevokeAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureDiskRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ClearIds(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings RemoveIds(this AzureDiskRevokeAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings RemoveIds(this AzureDiskRevokeAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetName(this AzureDiskRevokeAccessSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetName(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetResourceGroup(this AzureDiskRevokeAccessSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetResourceGroup(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetSubscription(this AzureDiskRevokeAccessSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetSubscription(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetDebug(this AzureDiskRevokeAccessSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetDebug(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetHelp(this AzureDiskRevokeAccessSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetHelp(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetOutput(this AzureDiskRevokeAccessSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetOutput(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetQuery(this AzureDiskRevokeAccessSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetQuery(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskRevokeAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings SetVerbose(this AzureDiskRevokeAccessSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskRevokeAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskRevokeAccessSettings ResetVerbose(this AzureDiskRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetIds(this AzureDiskShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetIds(this AzureDiskShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings AddIds(this AzureDiskShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings AddIds(this AzureDiskShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureDiskShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ClearIds(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings RemoveIds(this AzureDiskShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings RemoveIds(this AzureDiskShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetName(this AzureDiskShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetName(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetResourceGroup(this AzureDiskShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetResourceGroup(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetSubscription(this AzureDiskShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetSubscription(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetDebug(this AzureDiskShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetDebug(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetHelp(this AzureDiskShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetHelp(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetOutput(this AzureDiskShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetOutput(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetQuery(this AzureDiskShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetQuery(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings SetVerbose(this AzureDiskShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskShowSettings ResetVerbose(this AzureDiskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskUpdateSettingsExtensions
    {
        #region DiskIopsReadWrite
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.DiskIopsReadWrite"/></em></p>
        ///   <p>The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetDiskIopsReadWrite(this AzureDiskUpdateSettings toolSettings, string diskIopsReadWrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskIopsReadWrite = diskIopsReadWrite;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.DiskIopsReadWrite"/></em></p>
        ///   <p>The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetDiskIopsReadWrite(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskIopsReadWrite = null;
            return toolSettings;
        }
        #endregion
        #region DiskMbpsReadWrite
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.DiskMbpsReadWrite"/></em></p>
        ///   <p>The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetDiskMbpsReadWrite(this AzureDiskUpdateSettings toolSettings, string diskMbpsReadWrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskMbpsReadWrite = diskMbpsReadWrite;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.DiskMbpsReadWrite"/></em></p>
        ///   <p>The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetDiskMbpsReadWrite(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskMbpsReadWrite = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetNoWait(this AzureDiskUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetNoWait(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDiskUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings EnableNoWait(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDiskUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings DisableNoWait(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDiskUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ToggleNoWait(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SizeGb
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.SizeGb"/></em></p>
        ///   <p>Size in GB. Max size: 4095 GB (certain preview disks can be larger).</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetSizeGb(this AzureDiskUpdateSettings toolSettings, string sizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = sizeGb;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.SizeGb"/></em></p>
        ///   <p>Size in GB. Max size: 4095 GB (certain preview disks can be larger).</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetSizeGb(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Sku"/></em></p>
        ///   <p>Underlying storage SKU.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetSku(this AzureDiskUpdateSettings toolSettings, DiskSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Sku"/></em></p>
        ///   <p>Underlying storage SKU.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetSku(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetIds(this AzureDiskUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetIds(this AzureDiskUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings AddIds(this AzureDiskUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings AddIds(this AzureDiskUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureDiskUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ClearIds(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings RemoveIds(this AzureDiskUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings RemoveIds(this AzureDiskUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetName(this AzureDiskUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetName(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetResourceGroup(this AzureDiskUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetResourceGroup(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetSubscription(this AzureDiskUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetSubscription(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetAdd(this AzureDiskUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetAdd(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetForceString(this AzureDiskUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetForceString(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetRemove(this AzureDiskUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetRemove(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetSet(this AzureDiskUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetSet(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetDebug(this AzureDiskUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetDebug(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetHelp(this AzureDiskUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetHelp(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetOutput(this AzureDiskUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetOutput(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetQuery(this AzureDiskUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetQuery(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings SetVerbose(this AzureDiskUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskUpdateSettings ResetVerbose(this AzureDiskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDiskWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDiskWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetIds(this AzureDiskWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetIds(this AzureDiskWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings AddIds(this AzureDiskWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureDiskWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings AddIds(this AzureDiskWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureDiskWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ClearIds(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings RemoveIds(this AzureDiskWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureDiskWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings RemoveIds(this AzureDiskWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetName(this AzureDiskWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Name"/></em></p>
        ///   <p>The name of the managed disk.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetName(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetResourceGroup(this AzureDiskWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetResourceGroup(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetSubscription(this AzureDiskWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetSubscription(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetCreated(this AzureDiskWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetCreated(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetCustom(this AzureDiskWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetCustom(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetDeleted(this AzureDiskWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetDeleted(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetExists(this AzureDiskWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetExists(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetInterval(this AzureDiskWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetInterval(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetTimeout(this AzureDiskWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetTimeout(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetUpdated(this AzureDiskWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetUpdated(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetDebug(this AzureDiskWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetDebug(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetHelp(this AzureDiskWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetHelp(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetOutput(this AzureDiskWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetOutput(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetQuery(this AzureDiskWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetQuery(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDiskWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings SetVerbose(this AzureDiskWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDiskWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDiskWaitSettings ResetVerbose(this AzureDiskWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region DiskCreateHyperVGeneration
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<DiskCreateHyperVGeneration>))]
    public partial class DiskCreateHyperVGeneration : Enumeration
    {
        public static DiskCreateHyperVGeneration v1 = new DiskCreateHyperVGeneration { Value = "v1" };
        public static DiskCreateHyperVGeneration v2 = new DiskCreateHyperVGeneration { Value = "v2" };
    }
    #endregion
    #region DiskCreateOsType
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<DiskCreateOsType>))]
    public partial class DiskCreateOsType : Enumeration
    {
        public static DiskCreateOsType linux = new DiskCreateOsType { Value = "linux" };
        public static DiskCreateOsType windows = new DiskCreateOsType { Value = "windows" };
    }
    #endregion
    #region DiskSku
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<DiskSku>))]
    public partial class DiskSku : Enumeration
    {
        public static DiskSku premium_lrs = new DiskSku { Value = "premium_lrs" };
        public static DiskSku standardssd_lrs = new DiskSku { Value = "standardssd_lrs" };
        public static DiskSku standard_lrs = new DiskSku { Value = "standard_lrs" };
        public static DiskSku ultrassd_lrs = new DiskSku { Value = "ultrassd_lrs" };
    }
    #endregion
    #region DiskCreateZone
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<DiskCreateZone>))]
    public partial class DiskCreateZone : Enumeration
    {
        public static DiskCreateZone _1 = new DiskCreateZone { Value = "1" };
        public static DiskCreateZone _2 = new DiskCreateZone { Value = "2" };
        public static DiskCreateZone _3 = new DiskCreateZone { Value = "3" };
    }
    #endregion
    #region DiskGrantAccessAccessLevel
    /// <summary>
    ///   Used within <see cref="AzureDiskTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<DiskGrantAccessAccessLevel>))]
    public partial class DiskGrantAccessAccessLevel : Enumeration
    {
        public static DiskGrantAccessAccessLevel read = new DiskGrantAccessAccessLevel { Value = "read" };
        public static DiskGrantAccessAccessLevel write = new DiskGrantAccessAccessLevel { Value = "write" };
    }
    #endregion
}

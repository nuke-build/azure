// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureContainer.json
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
    public static partial class AzureContainerTasks
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public static string AzureContainerPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURECONTAINER_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureContainerLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Container Instances.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainer(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureContainerPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureContainerLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerAttach(AzureContainerAttachSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerAttachSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureContainerAttachSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerAttachSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerAttachSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerAttachSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerAttachSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerAttachSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerAttachSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerAttachSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerAttachSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerAttachSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerAttach(Configure<AzureContainerAttachSettings> configurator)
        {
            return AzureContainerAttach(configurator(new AzureContainerAttachSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureContainerAttachSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerAttachSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerAttachSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerAttachSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerAttachSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerAttachSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerAttachSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerAttachSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerAttachSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerAttachSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerAttachSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerAttach(CombinatorialConfigure<AzureContainerAttachSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerAttach, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerCreate(AzureContainerCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assign-identity</c> via <see cref="AzureContainerCreateSettings.AssignIdentity"/></li>
        ///     <li><c>--azure-file-volume-account-key</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountKey"/></li>
        ///     <li><c>--azure-file-volume-account-name</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountName"/></li>
        ///     <li><c>--azure-file-volume-mount-path</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeMountPath"/></li>
        ///     <li><c>--azure-file-volume-share-name</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeShareName"/></li>
        ///     <li><c>--command-line</c> via <see cref="AzureContainerCreateSettings.CommandLine"/></li>
        ///     <li><c>--cpu</c> via <see cref="AzureContainerCreateSettings.Cpu"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerCreateSettings.Debug"/></li>
        ///     <li><c>--dns-name-label</c> via <see cref="AzureContainerCreateSettings.DnsNameLabel"/></li>
        ///     <li><c>--environment-variables</c> via <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/></li>
        ///     <li><c>--file</c> via <see cref="AzureContainerCreateSettings.File"/></li>
        ///     <li><c>--gitrepo-dir</c> via <see cref="AzureContainerCreateSettings.GitrepoDir"/></li>
        ///     <li><c>--gitrepo-mount-path</c> via <see cref="AzureContainerCreateSettings.GitrepoMountPath"/></li>
        ///     <li><c>--gitrepo-revision</c> via <see cref="AzureContainerCreateSettings.GitrepoRevision"/></li>
        ///     <li><c>--gitrepo-url</c> via <see cref="AzureContainerCreateSettings.GitrepoUrl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerCreateSettings.Help"/></li>
        ///     <li><c>--image</c> via <see cref="AzureContainerCreateSettings.Image"/></li>
        ///     <li><c>--ip-address</c> via <see cref="AzureContainerCreateSettings.IpAddress"/></li>
        ///     <li><c>--location</c> via <see cref="AzureContainerCreateSettings.Location"/></li>
        ///     <li><c>--log-analytics-workspace</c> via <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspace"/></li>
        ///     <li><c>--log-analytics-workspace-key</c> via <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspaceKey"/></li>
        ///     <li><c>--memory</c> via <see cref="AzureContainerCreateSettings.Memory"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerCreateSettings.Name"/></li>
        ///     <li><c>--network-profile</c> via <see cref="AzureContainerCreateSettings.NetworkProfile"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureContainerCreateSettings.NoWait"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureContainerCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerCreateSettings.Output"/></li>
        ///     <li><c>--ports</c> via <see cref="AzureContainerCreateSettings.Ports"/></li>
        ///     <li><c>--protocol</c> via <see cref="AzureContainerCreateSettings.Protocol"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerCreateSettings.Query"/></li>
        ///     <li><c>--registry-login-server</c> via <see cref="AzureContainerCreateSettings.RegistryLoginServer"/></li>
        ///     <li><c>--registry-password</c> via <see cref="AzureContainerCreateSettings.RegistryPassword"/></li>
        ///     <li><c>--registry-username</c> via <see cref="AzureContainerCreateSettings.RegistryUsername"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--restart-policy</c> via <see cref="AzureContainerCreateSettings.RestartPolicy"/></li>
        ///     <li><c>--role</c> via <see cref="AzureContainerCreateSettings.Role"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureContainerCreateSettings.Scope"/></li>
        ///     <li><c>--secrets</c> via <see cref="AzureContainerCreateSettings.Secrets"/></li>
        ///     <li><c>--secrets-mount-path</c> via <see cref="AzureContainerCreateSettings.SecretsMountPath"/></li>
        ///     <li><c>--secure-environment-variables</c> via <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureContainerCreateSettings.Subnet"/></li>
        ///     <li><c>--subnet-address-prefix</c> via <see cref="AzureContainerCreateSettings.SubnetAddressPrefix"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet</c> via <see cref="AzureContainerCreateSettings.Vnet"/></li>
        ///     <li><c>--vnet-address-prefix</c> via <see cref="AzureContainerCreateSettings.VnetAddressPrefix"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureContainerCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerCreate(Configure<AzureContainerCreateSettings> configurator)
        {
            return AzureContainerCreate(configurator(new AzureContainerCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assign-identity</c> via <see cref="AzureContainerCreateSettings.AssignIdentity"/></li>
        ///     <li><c>--azure-file-volume-account-key</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountKey"/></li>
        ///     <li><c>--azure-file-volume-account-name</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountName"/></li>
        ///     <li><c>--azure-file-volume-mount-path</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeMountPath"/></li>
        ///     <li><c>--azure-file-volume-share-name</c> via <see cref="AzureContainerCreateSettings.AzureFileVolumeShareName"/></li>
        ///     <li><c>--command-line</c> via <see cref="AzureContainerCreateSettings.CommandLine"/></li>
        ///     <li><c>--cpu</c> via <see cref="AzureContainerCreateSettings.Cpu"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerCreateSettings.Debug"/></li>
        ///     <li><c>--dns-name-label</c> via <see cref="AzureContainerCreateSettings.DnsNameLabel"/></li>
        ///     <li><c>--environment-variables</c> via <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/></li>
        ///     <li><c>--file</c> via <see cref="AzureContainerCreateSettings.File"/></li>
        ///     <li><c>--gitrepo-dir</c> via <see cref="AzureContainerCreateSettings.GitrepoDir"/></li>
        ///     <li><c>--gitrepo-mount-path</c> via <see cref="AzureContainerCreateSettings.GitrepoMountPath"/></li>
        ///     <li><c>--gitrepo-revision</c> via <see cref="AzureContainerCreateSettings.GitrepoRevision"/></li>
        ///     <li><c>--gitrepo-url</c> via <see cref="AzureContainerCreateSettings.GitrepoUrl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerCreateSettings.Help"/></li>
        ///     <li><c>--image</c> via <see cref="AzureContainerCreateSettings.Image"/></li>
        ///     <li><c>--ip-address</c> via <see cref="AzureContainerCreateSettings.IpAddress"/></li>
        ///     <li><c>--location</c> via <see cref="AzureContainerCreateSettings.Location"/></li>
        ///     <li><c>--log-analytics-workspace</c> via <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspace"/></li>
        ///     <li><c>--log-analytics-workspace-key</c> via <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspaceKey"/></li>
        ///     <li><c>--memory</c> via <see cref="AzureContainerCreateSettings.Memory"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerCreateSettings.Name"/></li>
        ///     <li><c>--network-profile</c> via <see cref="AzureContainerCreateSettings.NetworkProfile"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureContainerCreateSettings.NoWait"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureContainerCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerCreateSettings.Output"/></li>
        ///     <li><c>--ports</c> via <see cref="AzureContainerCreateSettings.Ports"/></li>
        ///     <li><c>--protocol</c> via <see cref="AzureContainerCreateSettings.Protocol"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerCreateSettings.Query"/></li>
        ///     <li><c>--registry-login-server</c> via <see cref="AzureContainerCreateSettings.RegistryLoginServer"/></li>
        ///     <li><c>--registry-password</c> via <see cref="AzureContainerCreateSettings.RegistryPassword"/></li>
        ///     <li><c>--registry-username</c> via <see cref="AzureContainerCreateSettings.RegistryUsername"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--restart-policy</c> via <see cref="AzureContainerCreateSettings.RestartPolicy"/></li>
        ///     <li><c>--role</c> via <see cref="AzureContainerCreateSettings.Role"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureContainerCreateSettings.Scope"/></li>
        ///     <li><c>--secrets</c> via <see cref="AzureContainerCreateSettings.Secrets"/></li>
        ///     <li><c>--secrets-mount-path</c> via <see cref="AzureContainerCreateSettings.SecretsMountPath"/></li>
        ///     <li><c>--secure-environment-variables</c> via <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureContainerCreateSettings.Subnet"/></li>
        ///     <li><c>--subnet-address-prefix</c> via <see cref="AzureContainerCreateSettings.SubnetAddressPrefix"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet</c> via <see cref="AzureContainerCreateSettings.Vnet"/></li>
        ///     <li><c>--vnet-address-prefix</c> via <see cref="AzureContainerCreateSettings.VnetAddressPrefix"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureContainerCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerCreate(CombinatorialConfigure<AzureContainerCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerCreate, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerDelete(AzureContainerDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureContainerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerDelete(Configure<AzureContainerDeleteSettings> configurator)
        {
            return AzureContainerDelete(configurator(new AzureContainerDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureContainerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerDelete(CombinatorialConfigure<AzureContainerDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerDelete, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerExec(AzureContainerExecSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerExecSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureContainerExecSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerExecSettings.Debug"/></li>
        ///     <li><c>--exec-command</c> via <see cref="AzureContainerExecSettings.ExecCommand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerExecSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerExecSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerExecSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerExecSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerExecSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerExecSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerExecSettings.Subscription"/></li>
        ///     <li><c>--terminal-col-size</c> via <see cref="AzureContainerExecSettings.TerminalColSize"/></li>
        ///     <li><c>--terminal-row-size</c> via <see cref="AzureContainerExecSettings.TerminalRowSize"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerExecSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerExec(Configure<AzureContainerExecSettings> configurator)
        {
            return AzureContainerExec(configurator(new AzureContainerExecSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureContainerExecSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerExecSettings.Debug"/></li>
        ///     <li><c>--exec-command</c> via <see cref="AzureContainerExecSettings.ExecCommand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerExecSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerExecSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerExecSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerExecSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerExecSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerExecSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerExecSettings.Subscription"/></li>
        ///     <li><c>--terminal-col-size</c> via <see cref="AzureContainerExecSettings.TerminalColSize"/></li>
        ///     <li><c>--terminal-row-size</c> via <see cref="AzureContainerExecSettings.TerminalRowSize"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerExecSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerExecSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerExec(CombinatorialConfigure<AzureContainerExecSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerExec, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerExport(AzureContainerExportSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerExportSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerExportSettings.Debug"/></li>
        ///     <li><c>--file</c> via <see cref="AzureContainerExportSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerExportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerExportSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerExportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerExportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerExportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerExport(Configure<AzureContainerExportSettings> configurator)
        {
            return AzureContainerExport(configurator(new AzureContainerExportSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerExportSettings.Debug"/></li>
        ///     <li><c>--file</c> via <see cref="AzureContainerExportSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerExportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerExportSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerExportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerExportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerExportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerExportSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerExport(CombinatorialConfigure<AzureContainerExportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerExport, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerList(AzureContainerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerList(Configure<AzureContainerListSettings> configurator)
        {
            return AzureContainerList(configurator(new AzureContainerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerList(CombinatorialConfigure<AzureContainerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerList, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerLogs(AzureContainerLogsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerLogsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureContainerLogsSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerLogsSettings.Debug"/></li>
        ///     <li><c>--follow</c> via <see cref="AzureContainerLogsSettings.Follow"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerLogsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerLogsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerLogsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerLogsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerLogsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerLogsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerLogsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerLogsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerLogs(Configure<AzureContainerLogsSettings> configurator)
        {
            return AzureContainerLogs(configurator(new AzureContainerLogsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureContainerLogsSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureContainerLogsSettings.Debug"/></li>
        ///     <li><c>--follow</c> via <see cref="AzureContainerLogsSettings.Follow"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerLogsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerLogsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerLogsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerLogsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerLogsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerLogsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerLogsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerLogsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerLogsSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerLogs(CombinatorialConfigure<AzureContainerLogsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerLogs, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerRestart(AzureContainerRestartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerRestartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerRestartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerRestartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureContainerRestartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerRestart(Configure<AzureContainerRestartSettings> configurator)
        {
            return AzureContainerRestart(configurator(new AzureContainerRestartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerRestartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerRestartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureContainerRestartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerRestartSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerRestart(CombinatorialConfigure<AzureContainerRestartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerRestart, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerShow(AzureContainerShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerShow(Configure<AzureContainerShowSettings> configurator)
        {
            return AzureContainerShow(configurator(new AzureContainerShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureContainerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerShow(CombinatorialConfigure<AzureContainerShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerShow, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerStart(AzureContainerStartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerStartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerStartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureContainerStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerStartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerStart(Configure<AzureContainerStartSettings> configurator)
        {
            return AzureContainerStart(configurator(new AzureContainerStartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerStartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureContainerStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerStartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerStartSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerStart(CombinatorialConfigure<AzureContainerStartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerStart, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureContainerStop(AzureContainerStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureContainerStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerStopSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureContainerStop(Configure<AzureContainerStopSettings> configurator)
        {
            return AzureContainerStop(configurator(new AzureContainerStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/container?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureContainerStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureContainerStopSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureContainerStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureContainerStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureContainerStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureContainerStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureContainerStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureContainerStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureContainerStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureContainerStop(CombinatorialConfigure<AzureContainerStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureContainerStop, AzureContainerLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureContainerAttachSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerAttachSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The container to attach to. If omitted, the first container in the container group will be chosen.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the container group.
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
              .Add("container attach")
              .Add("--container-name {value}", ContainerName)
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
    #region AzureContainerCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.
        /// </summary>
        public virtual string CommandLine { get; internal set; }
        /// <summary>
        ///   The required number of CPU cores of the containers, accurate to one decimal place.
        /// </summary>
        public virtual string Cpu { get; internal set; }
        /// <summary>
        ///   The dns name label for container group with public IP.
        /// </summary>
        public virtual string DnsNameLabel { get; internal set; }
        /// <summary>
        ///   A list of environment variable for the container. Space-separated values in 'key=value' format.
        /// </summary>
        public virtual IReadOnlyDictionary<string, object> AzureEnvironmentVariables => AzureEnvironmentVariablesInternal.AsReadOnly();
        internal Dictionary<string, object> AzureEnvironmentVariablesInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        ///   The path to the input file.
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   The container image name.
        /// </summary>
        public virtual string Image { get; internal set; }
        /// <summary>
        ///   The IP address type of the container group.
        /// </summary>
        public virtual ContainerCreateIpAddress IpAddress { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The required memory of the containers in GB, accurate to one decimal place.
        /// </summary>
        public virtual string Memory { get; internal set; }
        /// <summary>
        ///   The name of the container group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The OS type of the containers.
        /// </summary>
        public virtual ContainerCreateOsType OsType { get; internal set; }
        /// <summary>
        ///   The ports to open.
        /// </summary>
        public virtual string Ports { get; internal set; }
        /// <summary>
        ///   The network protocol to use.
        /// </summary>
        public virtual ContainerCreateProtocol Protocol { get; internal set; }
        /// <summary>
        ///   Restart policy for all containers within the container group.
        /// </summary>
        public virtual ContainerCreateRestartPolicy RestartPolicy { get; internal set; }
        /// <summary>
        ///   Space-separated secrets in 'key=value' format.
        /// </summary>
        public virtual IReadOnlyDictionary<string, object> Secrets => SecretsInternal.AsReadOnly();
        internal Dictionary<string, object> SecretsInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        ///   The path within the container where the secrets volume should be mounted. Must not contain colon ':'.
        /// </summary>
        public virtual string SecretsMountPath { get; internal set; }
        /// <summary>
        ///   A list of secure environment variable for the container. Space-separated values in 'key=value' format.
        /// </summary>
        public virtual IReadOnlyDictionary<string, object> SecureEnvironmentVariables => SecureEnvironmentVariablesInternal.AsReadOnly();
        internal Dictionary<string, object> SecureEnvironmentVariablesInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        ///   The storage account access key used to access the Azure File share.
        /// </summary>
        public virtual string AzureFileVolumeAccountKey { get; internal set; }
        /// <summary>
        ///   The name of the storage account that contains the Azure File share.
        /// </summary>
        public virtual string AzureFileVolumeAccountName { get; internal set; }
        /// <summary>
        ///   The path within the container where the azure file volume should be mounted. Must not contain colon ':'.
        /// </summary>
        public virtual string AzureFileVolumeMountPath { get; internal set; }
        /// <summary>
        ///   The name of the Azure File share to be mounted as a volume.
        /// </summary>
        public virtual string AzureFileVolumeShareName { get; internal set; }
        /// <summary>
        ///   The target directory path in the git repository. Must not contain '..'.
        /// </summary>
        public virtual string GitrepoDir { get; internal set; }
        /// <summary>
        ///   The path within the container where the git repo volume should be mounted. Must not contain colon ':'.
        /// </summary>
        public virtual string GitrepoMountPath { get; internal set; }
        /// <summary>
        ///   The commit hash for the specified revision.
        /// </summary>
        public virtual string GitrepoRevision { get; internal set; }
        /// <summary>
        ///   The URL of a git repository to be mounted as a volume.
        /// </summary>
        public virtual string GitrepoUrl { get; internal set; }
        /// <summary>
        ///   The container image registry login server.
        /// </summary>
        public virtual string RegistryLoginServer { get; internal set; }
        /// <summary>
        ///   The password to log in container image registry server.
        /// </summary>
        public virtual string RegistryPassword { get; internal set; }
        /// <summary>
        ///   The username to log in container image registry server.
        /// </summary>
        public virtual string RegistryUsername { get; internal set; }
        /// <summary>
        ///   The Log Analytics workspace name or id. Use the current subscription or use --subscription flag to set the desired subscription.
        /// </summary>
        public virtual string LogAnalyticsWorkspace { get; internal set; }
        /// <summary>
        ///   The Log Analytics workspace key.
        /// </summary>
        public virtual string LogAnalyticsWorkspaceKey { get; internal set; }
        /// <summary>
        ///   Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.
        /// </summary>
        public virtual IReadOnlyList<string> AssignIdentity => AssignIdentityInternal.AsReadOnly();
        internal List<string> AssignIdentityInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Role name or id the system assigned identity will have.
        /// </summary>
        public virtual string Role { get; internal set; }
        /// <summary>
        ///   Scope that the system assigned identity can access.
        /// </summary>
        public virtual string Scope { get; internal set; }
        /// <summary>
        ///   The network profile name or id.
        /// </summary>
        public virtual string NetworkProfile { get; internal set; }
        /// <summary>
        ///   The name of the subnet when creating a new VNET or referencing an existing one. Can also reference an existing subnet by ID.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   The subnet IP address prefix to use when creating a new VNET in CIDR format.
        /// </summary>
        public virtual string SubnetAddressPrefix { get; internal set; }
        /// <summary>
        ///   The name of the VNET when creating a new one or referencing an existing one. Can also reference an existing vnet by ID. This allows using vnets from other resource groups.
        /// </summary>
        public virtual string Vnet { get; internal set; }
        /// <summary>
        ///   The IP address prefix to use when creating a new VNET in CIDR format.
        /// </summary>
        public virtual string VnetAddressPrefix { get; internal set; }
        /// <summary>
        ///   The name of the VNET when creating a new one or referencing an existing one.
        /// </summary>
        public virtual string VnetName { get; internal set; }
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
              .Add("container create")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--command-line {value}", CommandLine)
              .Add("--cpu {value}", Cpu)
              .Add("--dns-name-label {value}", DnsNameLabel)
              .Add("--environment-variables {value}", AzureEnvironmentVariables, "{key}={value}", separator: ' ')
              .Add("--file {value}", File)
              .Add("--image {value}", Image)
              .Add("--ip-address {value}", IpAddress)
              .Add("--location {value}", Location)
              .Add("--memory {value}", Memory)
              .Add("--name {value}", Name)
              .Add("--no-wait", NoWait)
              .Add("--os-type {value}", OsType)
              .Add("--ports {value}", Ports)
              .Add("--protocol {value}", Protocol)
              .Add("--restart-policy {value}", RestartPolicy)
              .Add("--secrets {value}", Secrets, "{key}={value}", separator: ' ')
              .Add("--secrets-mount-path {value}", SecretsMountPath, secret: true)
              .Add("--secure-environment-variables {value}", SecureEnvironmentVariables, "{key}={value}", separator: ' ')
              .Add("--azure-file-volume-account-key {value}", AzureFileVolumeAccountKey)
              .Add("--azure-file-volume-account-name {value}", AzureFileVolumeAccountName)
              .Add("--azure-file-volume-mount-path {value}", AzureFileVolumeMountPath)
              .Add("--azure-file-volume-share-name {value}", AzureFileVolumeShareName)
              .Add("--gitrepo-dir {value}", GitrepoDir)
              .Add("--gitrepo-mount-path {value}", GitrepoMountPath)
              .Add("--gitrepo-revision {value}", GitrepoRevision)
              .Add("--gitrepo-url {value}", GitrepoUrl)
              .Add("--registry-login-server {value}", RegistryLoginServer)
              .Add("--registry-password {value}", RegistryPassword, secret: true)
              .Add("--registry-username {value}", RegistryUsername)
              .Add("--log-analytics-workspace {value}", LogAnalyticsWorkspace)
              .Add("--log-analytics-workspace-key {value}", LogAnalyticsWorkspaceKey)
              .Add("--assign-identity {value}", AssignIdentity, separator: ' ')
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
              .Add("--network-profile {value}", NetworkProfile)
              .Add("--subnet {value}", Subnet)
              .Add("--subnet-address-prefix {value}", SubnetAddressPrefix)
              .Add("--vnet {value}", Vnet)
              .Add("--vnet-address-prefix {value}", VnetAddressPrefix)
              .Add("--vnet-name {value}", VnetName)
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
    #region AzureContainerDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
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
        ///   The name of the container group.
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
              .Add("container delete")
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
    #region AzureContainerExecSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerExecSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The command to run from within the container.
        /// </summary>
        public virtual string ExecCommand { get; internal set; }
        /// <summary>
        ///   The container name where to execute the command. Can be ommitted for container groups with only one container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   The col size for the command output.
        /// </summary>
        public virtual string TerminalColSize { get; internal set; }
        /// <summary>
        ///   The row size for the command output.
        /// </summary>
        public virtual string TerminalRowSize { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the container group.
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
              .Add("container exec")
              .Add("--exec-command {value}", ExecCommand)
              .Add("--container-name {value}", ContainerName)
              .Add("--terminal-col-size {value}", TerminalColSize)
              .Add("--terminal-row-size {value}", TerminalRowSize)
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
    #region AzureContainerExportSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerExportSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The file path to export the container group.
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the container group.
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
              .Add("container export")
              .Add("--file {value}", File)
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
    #region AzureContainerListSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
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
              .Add("container list")
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
    #region AzureContainerLogsSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerLogsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The container name to tail the logs. If omitted, the first container in the container group will be chosen.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Indicate to stream the tailing logs.
        /// </summary>
        public virtual string Follow { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the container group.
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
              .Add("container logs")
              .Add("--container-name {value}", ContainerName)
              .Add("--follow {value}", Follow)
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
    #region AzureContainerRestartSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerRestartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The name of the container group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("container restart")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureContainerShowSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the container group.
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
              .Add("container show")
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
    #region AzureContainerStartSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerStartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The name of the container group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("container start")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureContainerStopSettings
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureContainer executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        public override Action<OutputType, string> CustomLogger => AzureContainerTasks.AzureContainerLogger;
        /// <summary>
        ///   The name of the container group.
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
              .Add("container stop")
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
    #region AzureContainerAttachSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerAttachSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.ContainerName"/></em></p>
        ///   <p>The container to attach to. If omitted, the first container in the container group will be chosen.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetContainerName(this AzureContainerAttachSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.ContainerName"/></em></p>
        ///   <p>The container to attach to. If omitted, the first container in the container group will be chosen.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetContainerName(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetIds(this AzureContainerAttachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetIds(this AzureContainerAttachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerAttachSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings AddIds(this AzureContainerAttachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerAttachSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings AddIds(this AzureContainerAttachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerAttachSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ClearIds(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerAttachSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings RemoveIds(this AzureContainerAttachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerAttachSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings RemoveIds(this AzureContainerAttachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetName(this AzureContainerAttachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetName(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetResourceGroup(this AzureContainerAttachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetResourceGroup(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetSubscription(this AzureContainerAttachSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetSubscription(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetDebug(this AzureContainerAttachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetDebug(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetHelp(this AzureContainerAttachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetHelp(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetOutput(this AzureContainerAttachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetOutput(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetQuery(this AzureContainerAttachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetQuery(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerAttachSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings SetVerbose(this AzureContainerAttachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerAttachSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerAttachSettings ResetVerbose(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerCreateSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetResourceGroup(this AzureContainerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetResourceGroup(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CommandLine
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.CommandLine"/></em></p>
        ///   <p>The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetCommandLine(this AzureContainerCreateSettings toolSettings, string commandLine)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandLine = commandLine;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.CommandLine"/></em></p>
        ///   <p>The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetCommandLine(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandLine = null;
            return toolSettings;
        }
        #endregion
        #region Cpu
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Cpu"/></em></p>
        ///   <p>The required number of CPU cores of the containers, accurate to one decimal place.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetCpu(this AzureContainerCreateSettings toolSettings, string cpu)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = cpu;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Cpu"/></em></p>
        ///   <p>The required number of CPU cores of the containers, accurate to one decimal place.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetCpu(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = null;
            return toolSettings;
        }
        #endregion
        #region DnsNameLabel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.DnsNameLabel"/></em></p>
        ///   <p>The dns name label for container group with public IP.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetDnsNameLabel(this AzureContainerCreateSettings toolSettings, string dnsNameLabel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNameLabel = dnsNameLabel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.DnsNameLabel"/></em></p>
        ///   <p>The dns name label for container group with public IP.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetDnsNameLabel(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNameLabel = null;
            return toolSettings;
        }
        #endregion
        #region AzureEnvironmentVariables
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/> to a new dictionary</em></p>
        ///   <p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureEnvironmentVariables(this AzureContainerCreateSettings toolSettings, IDictionary<string, object> azureEnvironmentVariables)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureEnvironmentVariablesInternal = azureEnvironmentVariables.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/></em></p>
        ///   <p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ClearAzureEnvironmentVariables(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureEnvironmentVariablesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds a new key-value-pair <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/></em></p>
        ///   <p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings AddAzureEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string azureEnvironmentVariableKey, object azureEnvironmentVariableValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureEnvironmentVariablesInternal.Add(azureEnvironmentVariableKey, azureEnvironmentVariableValue);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes a key-value-pair from <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/></em></p>
        ///   <p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveAzureEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string azureEnvironmentVariableKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureEnvironmentVariablesInternal.Remove(azureEnvironmentVariableKey);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets a key-value-pair in <see cref="AzureContainerCreateSettings.AzureEnvironmentVariables"/></em></p>
        ///   <p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string azureEnvironmentVariableKey, object azureEnvironmentVariableValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureEnvironmentVariablesInternal[azureEnvironmentVariableKey] = azureEnvironmentVariableValue;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.File"/></em></p>
        ///   <p>The path to the input file.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetFile(this AzureContainerCreateSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.File"/></em></p>
        ///   <p>The path to the input file.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetFile(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Image"/></em></p>
        ///   <p>The container image name.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetImage(this AzureContainerCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Image"/></em></p>
        ///   <p>The container image name.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetImage(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region IpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.IpAddress"/></em></p>
        ///   <p>The IP address type of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetIpAddress(this AzureContainerCreateSettings toolSettings, ContainerCreateIpAddress ipAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpAddress = ipAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.IpAddress"/></em></p>
        ///   <p>The IP address type of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetIpAddress(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetLocation(this AzureContainerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetLocation(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Memory
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Memory"/></em></p>
        ///   <p>The required memory of the containers in GB, accurate to one decimal place.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetMemory(this AzureContainerCreateSettings toolSettings, string memory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Memory = memory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Memory"/></em></p>
        ///   <p>The required memory of the containers in GB, accurate to one decimal place.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetMemory(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Memory = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetName(this AzureContainerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetNoWait(this AzureContainerCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetNoWait(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureContainerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings EnableNoWait(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureContainerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings DisableNoWait(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureContainerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ToggleNoWait(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.OsType"/></em></p>
        ///   <p>The OS type of the containers.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetOsType(this AzureContainerCreateSettings toolSettings, ContainerCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.OsType"/></em></p>
        ///   <p>The OS type of the containers.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetOsType(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region Ports
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Ports"/></em></p>
        ///   <p>The ports to open.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetPorts(this AzureContainerCreateSettings toolSettings, string ports)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ports = ports;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Ports"/></em></p>
        ///   <p>The ports to open.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetPorts(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ports = null;
            return toolSettings;
        }
        #endregion
        #region Protocol
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Protocol"/></em></p>
        ///   <p>The network protocol to use.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetProtocol(this AzureContainerCreateSettings toolSettings, ContainerCreateProtocol protocol)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Protocol = protocol;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Protocol"/></em></p>
        ///   <p>The network protocol to use.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetProtocol(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Protocol = null;
            return toolSettings;
        }
        #endregion
        #region RestartPolicy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.RestartPolicy"/></em></p>
        ///   <p>Restart policy for all containers within the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetRestartPolicy(this AzureContainerCreateSettings toolSettings, ContainerCreateRestartPolicy restartPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartPolicy = restartPolicy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.RestartPolicy"/></em></p>
        ///   <p>Restart policy for all containers within the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRestartPolicy(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartPolicy = null;
            return toolSettings;
        }
        #endregion
        #region Secrets
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Secrets"/> to a new dictionary</em></p>
        ///   <p>Space-separated secrets in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecrets(this AzureContainerCreateSettings toolSettings, IDictionary<string, object> secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal = secrets.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerCreateSettings.Secrets"/></em></p>
        ///   <p>Space-separated secrets in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ClearSecrets(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds a new key-value-pair <see cref="AzureContainerCreateSettings.Secrets"/></em></p>
        ///   <p>Space-separated secrets in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings AddSecret(this AzureContainerCreateSettings toolSettings, string secretKey, object secretValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Add(secretKey, secretValue);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes a key-value-pair from <see cref="AzureContainerCreateSettings.Secrets"/></em></p>
        ///   <p>Space-separated secrets in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveSecret(this AzureContainerCreateSettings toolSettings, string secretKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Remove(secretKey);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets a key-value-pair in <see cref="AzureContainerCreateSettings.Secrets"/></em></p>
        ///   <p>Space-separated secrets in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecret(this AzureContainerCreateSettings toolSettings, string secretKey, object secretValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal[secretKey] = secretValue;
            return toolSettings;
        }
        #endregion
        #region SecretsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.SecretsMountPath"/></em></p>
        ///   <p>The path within the container where the secrets volume should be mounted. Must not contain colon ':'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecretsMountPath(this AzureContainerCreateSettings toolSettings, string secretsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsMountPath = secretsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.SecretsMountPath"/></em></p>
        ///   <p>The path within the container where the secrets volume should be mounted. Must not contain colon ':'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetSecretsMountPath(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region SecureEnvironmentVariables
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/> to a new dictionary</em></p>
        ///   <p>A list of secure environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecureEnvironmentVariables(this AzureContainerCreateSettings toolSettings, IDictionary<string, object> secureEnvironmentVariables)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecureEnvironmentVariablesInternal = secureEnvironmentVariables.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/></em></p>
        ///   <p>A list of secure environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ClearSecureEnvironmentVariables(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecureEnvironmentVariablesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds a new key-value-pair <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/></em></p>
        ///   <p>A list of secure environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings AddSecureEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string secureEnvironmentVariableKey, object secureEnvironmentVariableValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecureEnvironmentVariablesInternal.Add(secureEnvironmentVariableKey, secureEnvironmentVariableValue);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes a key-value-pair from <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/></em></p>
        ///   <p>A list of secure environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveSecureEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string secureEnvironmentVariableKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecureEnvironmentVariablesInternal.Remove(secureEnvironmentVariableKey);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets a key-value-pair in <see cref="AzureContainerCreateSettings.SecureEnvironmentVariables"/></em></p>
        ///   <p>A list of secure environment variable for the container. Space-separated values in 'key=value' format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecureEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string secureEnvironmentVariableKey, object secureEnvironmentVariableValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecureEnvironmentVariablesInternal[secureEnvironmentVariableKey] = secureEnvironmentVariableValue;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeAccountKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountKey"/></em></p>
        ///   <p>The storage account access key used to access the Azure File share.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeAccountKey(this AzureContainerCreateSettings toolSettings, string azureFileVolumeAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountKey = azureFileVolumeAccountKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountKey"/></em></p>
        ///   <p>The storage account access key used to access the Azure File share.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeAccountKey(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeAccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountName"/></em></p>
        ///   <p>The name of the storage account that contains the Azure File share.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeAccountName(this AzureContainerCreateSettings toolSettings, string azureFileVolumeAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountName = azureFileVolumeAccountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountName"/></em></p>
        ///   <p>The name of the storage account that contains the Azure File share.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeAccountName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountName = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeMountPath"/></em></p>
        ///   <p>The path within the container where the azure file volume should be mounted. Must not contain colon ':'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeMountPath(this AzureContainerCreateSettings toolSettings, string azureFileVolumeMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeMountPath = azureFileVolumeMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeMountPath"/></em></p>
        ///   <p>The path within the container where the azure file volume should be mounted. Must not contain colon ':'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeMountPath(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeShareName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeShareName"/></em></p>
        ///   <p>The name of the Azure File share to be mounted as a volume.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeShareName(this AzureContainerCreateSettings toolSettings, string azureFileVolumeShareName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeShareName = azureFileVolumeShareName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeShareName"/></em></p>
        ///   <p>The name of the Azure File share to be mounted as a volume.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeShareName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeShareName = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoDir
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoDir"/></em></p>
        ///   <p>The target directory path in the git repository. Must not contain '..'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoDir(this AzureContainerCreateSettings toolSettings, string gitrepoDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoDir = gitrepoDir;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoDir"/></em></p>
        ///   <p>The target directory path in the git repository. Must not contain '..'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoDir(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoDir = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoMountPath"/></em></p>
        ///   <p>The path within the container where the git repo volume should be mounted. Must not contain colon ':'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoMountPath(this AzureContainerCreateSettings toolSettings, string gitrepoMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoMountPath = gitrepoMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoMountPath"/></em></p>
        ///   <p>The path within the container where the git repo volume should be mounted. Must not contain colon ':'.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoMountPath(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoMountPath = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoRevision
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoRevision"/></em></p>
        ///   <p>The commit hash for the specified revision.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoRevision(this AzureContainerCreateSettings toolSettings, string gitrepoRevision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoRevision = gitrepoRevision;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoRevision"/></em></p>
        ///   <p>The commit hash for the specified revision.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoRevision(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoRevision = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoUrl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoUrl"/></em></p>
        ///   <p>The URL of a git repository to be mounted as a volume.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoUrl(this AzureContainerCreateSettings toolSettings, string gitrepoUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoUrl = gitrepoUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoUrl"/></em></p>
        ///   <p>The URL of a git repository to be mounted as a volume.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoUrl(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoUrl = null;
            return toolSettings;
        }
        #endregion
        #region RegistryLoginServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.RegistryLoginServer"/></em></p>
        ///   <p>The container image registry login server.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetRegistryLoginServer(this AzureContainerCreateSettings toolSettings, string registryLoginServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryLoginServer = registryLoginServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.RegistryLoginServer"/></em></p>
        ///   <p>The container image registry login server.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRegistryLoginServer(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryLoginServer = null;
            return toolSettings;
        }
        #endregion
        #region RegistryPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.RegistryPassword"/></em></p>
        ///   <p>The password to log in container image registry server.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetRegistryPassword(this AzureContainerCreateSettings toolSettings, string registryPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryPassword = registryPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.RegistryPassword"/></em></p>
        ///   <p>The password to log in container image registry server.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRegistryPassword(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryPassword = null;
            return toolSettings;
        }
        #endregion
        #region RegistryUsername
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.RegistryUsername"/></em></p>
        ///   <p>The username to log in container image registry server.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetRegistryUsername(this AzureContainerCreateSettings toolSettings, string registryUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryUsername = registryUsername;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.RegistryUsername"/></em></p>
        ///   <p>The username to log in container image registry server.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRegistryUsername(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryUsername = null;
            return toolSettings;
        }
        #endregion
        #region LogAnalyticsWorkspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspace"/></em></p>
        ///   <p>The Log Analytics workspace name or id. Use the current subscription or use --subscription flag to set the desired subscription.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetLogAnalyticsWorkspace(this AzureContainerCreateSettings toolSettings, string logAnalyticsWorkspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogAnalyticsWorkspace = logAnalyticsWorkspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspace"/></em></p>
        ///   <p>The Log Analytics workspace name or id. Use the current subscription or use --subscription flag to set the desired subscription.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetLogAnalyticsWorkspace(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogAnalyticsWorkspace = null;
            return toolSettings;
        }
        #endregion
        #region LogAnalyticsWorkspaceKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspaceKey"/></em></p>
        ///   <p>The Log Analytics workspace key.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetLogAnalyticsWorkspaceKey(this AzureContainerCreateSettings toolSettings, string logAnalyticsWorkspaceKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogAnalyticsWorkspaceKey = logAnalyticsWorkspaceKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.LogAnalyticsWorkspaceKey"/></em></p>
        ///   <p>The Log Analytics workspace key.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetLogAnalyticsWorkspaceKey(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogAnalyticsWorkspaceKey = null;
            return toolSettings;
        }
        #endregion
        #region AssignIdentity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AssignIdentity"/> to a new list</em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAssignIdentity(this AzureContainerCreateSettings toolSettings, params string[] assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentityInternal = assignIdentity.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.AssignIdentity"/> to a new list</em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetAssignIdentity(this AzureContainerCreateSettings toolSettings, IEnumerable<string> assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentityInternal = assignIdentity.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings AddAssignIdentity(this AzureContainerCreateSettings toolSettings, params string[] assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentityInternal.AddRange(assignIdentity);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings AddAssignIdentity(this AzureContainerCreateSettings toolSettings, IEnumerable<string> assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentityInternal.AddRange(assignIdentity);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ClearAssignIdentity(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentityInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveAssignIdentity(this AzureContainerCreateSettings toolSettings, params string[] assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(assignIdentity);
            toolSettings.AssignIdentityInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Space-separated list of assigned identities. Assigned identities are either user assigned identities (resource IDs) and / or the system assigned identity ('[system]'). See examples for more info.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveAssignIdentity(this AzureContainerCreateSettings toolSettings, IEnumerable<string> assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(assignIdentity);
            toolSettings.AssignIdentityInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Role"/></em></p>
        ///   <p>Role name or id the system assigned identity will have.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetRole(this AzureContainerCreateSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Role"/></em></p>
        ///   <p>Role name or id the system assigned identity will have.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRole(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Scope"/></em></p>
        ///   <p>Scope that the system assigned identity can access.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetScope(this AzureContainerCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Scope"/></em></p>
        ///   <p>Scope that the system assigned identity can access.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetScope(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region NetworkProfile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.NetworkProfile"/></em></p>
        ///   <p>The network profile name or id.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetNetworkProfile(this AzureContainerCreateSettings toolSettings, string networkProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkProfile = networkProfile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.NetworkProfile"/></em></p>
        ///   <p>The network profile name or id.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetNetworkProfile(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkProfile = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Subnet"/></em></p>
        ///   <p>The name of the subnet when creating a new VNET or referencing an existing one. Can also reference an existing subnet by ID.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSubnet(this AzureContainerCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Subnet"/></em></p>
        ///   <p>The name of the subnet when creating a new VNET or referencing an existing one. Can also reference an existing subnet by ID.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetSubnet(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region SubnetAddressPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.SubnetAddressPrefix"/></em></p>
        ///   <p>The subnet IP address prefix to use when creating a new VNET in CIDR format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSubnetAddressPrefix(this AzureContainerCreateSettings toolSettings, string subnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetAddressPrefix = subnetAddressPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.SubnetAddressPrefix"/></em></p>
        ///   <p>The subnet IP address prefix to use when creating a new VNET in CIDR format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetSubnetAddressPrefix(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Vnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Vnet"/></em></p>
        ///   <p>The name of the VNET when creating a new one or referencing an existing one. Can also reference an existing vnet by ID. This allows using vnets from other resource groups.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetVnet(this AzureContainerCreateSettings toolSettings, string vnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vnet = vnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Vnet"/></em></p>
        ///   <p>The name of the VNET when creating a new one or referencing an existing one. Can also reference an existing vnet by ID. This allows using vnets from other resource groups.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetVnet(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vnet = null;
            return toolSettings;
        }
        #endregion
        #region VnetAddressPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.VnetAddressPrefix"/></em></p>
        ///   <p>The IP address prefix to use when creating a new VNET in CIDR format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetVnetAddressPrefix(this AzureContainerCreateSettings toolSettings, string vnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetAddressPrefix = vnetAddressPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.VnetAddressPrefix"/></em></p>
        ///   <p>The IP address prefix to use when creating a new VNET in CIDR format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetVnetAddressPrefix(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.VnetName"/></em></p>
        ///   <p>The name of the VNET when creating a new one or referencing an existing one.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetVnetName(this AzureContainerCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.VnetName"/></em></p>
        ///   <p>The name of the VNET when creating a new one or referencing an existing one.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetVnetName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetSubscription(this AzureContainerCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetSubscription(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetDebug(this AzureContainerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetDebug(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetHelp(this AzureContainerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetHelp(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetOutput(this AzureContainerCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetOutput(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetQuery(this AzureContainerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetQuery(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings SetVerbose(this AzureContainerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerCreateSettings ResetVerbose(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetYes(this AzureContainerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetYes(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetIds(this AzureContainerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetIds(this AzureContainerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings AddIds(this AzureContainerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings AddIds(this AzureContainerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ClearIds(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings RemoveIds(this AzureContainerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings RemoveIds(this AzureContainerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetName(this AzureContainerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetName(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetResourceGroup(this AzureContainerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetResourceGroup(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetSubscription(this AzureContainerDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetSubscription(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetDebug(this AzureContainerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetDebug(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetHelp(this AzureContainerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetHelp(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetOutput(this AzureContainerDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetOutput(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetQuery(this AzureContainerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetQuery(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings SetVerbose(this AzureContainerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetVerbose(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerExecSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerExecSettingsExtensions
    {
        #region ExecCommand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.ExecCommand"/></em></p>
        ///   <p>The command to run from within the container.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetExecCommand(this AzureContainerExecSettings toolSettings, string execCommand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecCommand = execCommand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.ExecCommand"/></em></p>
        ///   <p>The command to run from within the container.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetExecCommand(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecCommand = null;
            return toolSettings;
        }
        #endregion
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.ContainerName"/></em></p>
        ///   <p>The container name where to execute the command. Can be ommitted for container groups with only one container.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetContainerName(this AzureContainerExecSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.ContainerName"/></em></p>
        ///   <p>The container name where to execute the command. Can be ommitted for container groups with only one container.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetContainerName(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region TerminalColSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.TerminalColSize"/></em></p>
        ///   <p>The col size for the command output.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetTerminalColSize(this AzureContainerExecSettings toolSettings, string terminalColSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalColSize = terminalColSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.TerminalColSize"/></em></p>
        ///   <p>The col size for the command output.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetTerminalColSize(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalColSize = null;
            return toolSettings;
        }
        #endregion
        #region TerminalRowSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.TerminalRowSize"/></em></p>
        ///   <p>The row size for the command output.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetTerminalRowSize(this AzureContainerExecSettings toolSettings, string terminalRowSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalRowSize = terminalRowSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.TerminalRowSize"/></em></p>
        ///   <p>The row size for the command output.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetTerminalRowSize(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalRowSize = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetIds(this AzureContainerExecSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetIds(this AzureContainerExecSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerExecSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings AddIds(this AzureContainerExecSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerExecSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings AddIds(this AzureContainerExecSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerExecSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ClearIds(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerExecSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings RemoveIds(this AzureContainerExecSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerExecSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings RemoveIds(this AzureContainerExecSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetName(this AzureContainerExecSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetName(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetResourceGroup(this AzureContainerExecSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetResourceGroup(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetSubscription(this AzureContainerExecSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetSubscription(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetDebug(this AzureContainerExecSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetDebug(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetHelp(this AzureContainerExecSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetHelp(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetOutput(this AzureContainerExecSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetOutput(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetQuery(this AzureContainerExecSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetQuery(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExecSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings SetVerbose(this AzureContainerExecSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExecSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExecSettings ResetVerbose(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerExportSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerExportSettingsExtensions
    {
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.File"/></em></p>
        ///   <p>The file path to export the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetFile(this AzureContainerExportSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.File"/></em></p>
        ///   <p>The file path to export the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetFile(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetIds(this AzureContainerExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetIds(this AzureContainerExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings AddIds(this AzureContainerExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings AddIds(this AzureContainerExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ClearIds(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings RemoveIds(this AzureContainerExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings RemoveIds(this AzureContainerExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetName(this AzureContainerExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetName(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetResourceGroup(this AzureContainerExportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetResourceGroup(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetSubscription(this AzureContainerExportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetSubscription(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetDebug(this AzureContainerExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetDebug(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetHelp(this AzureContainerExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetHelp(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetOutput(this AzureContainerExportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetOutput(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetQuery(this AzureContainerExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetQuery(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings SetVerbose(this AzureContainerExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerExportSettings ResetVerbose(this AzureContainerExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetResourceGroup(this AzureContainerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetResourceGroup(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetSubscription(this AzureContainerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetSubscription(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetDebug(this AzureContainerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetDebug(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetHelp(this AzureContainerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetHelp(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetOutput(this AzureContainerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetOutput(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetQuery(this AzureContainerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetQuery(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings SetVerbose(this AzureContainerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerListSettings ResetVerbose(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerLogsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerLogsSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.ContainerName"/></em></p>
        ///   <p>The container name to tail the logs. If omitted, the first container in the container group will be chosen.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetContainerName(this AzureContainerLogsSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.ContainerName"/></em></p>
        ///   <p>The container name to tail the logs. If omitted, the first container in the container group will be chosen.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetContainerName(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region Follow
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Follow"/></em></p>
        ///   <p>Indicate to stream the tailing logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetFollow(this AzureContainerLogsSettings toolSettings, string follow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = follow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Follow"/></em></p>
        ///   <p>Indicate to stream the tailing logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetFollow(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetIds(this AzureContainerLogsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetIds(this AzureContainerLogsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerLogsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings AddIds(this AzureContainerLogsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerLogsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings AddIds(this AzureContainerLogsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerLogsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ClearIds(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerLogsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings RemoveIds(this AzureContainerLogsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerLogsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings RemoveIds(this AzureContainerLogsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetName(this AzureContainerLogsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetName(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetResourceGroup(this AzureContainerLogsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetResourceGroup(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetSubscription(this AzureContainerLogsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetSubscription(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetDebug(this AzureContainerLogsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetDebug(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetHelp(this AzureContainerLogsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetHelp(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetOutput(this AzureContainerLogsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetOutput(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetQuery(this AzureContainerLogsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetQuery(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerLogsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings SetVerbose(this AzureContainerLogsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerLogsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerLogsSettings ResetVerbose(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerRestartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerRestartSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetName(this AzureContainerRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetName(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetResourceGroup(this AzureContainerRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetResourceGroup(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetNoWait(this AzureContainerRestartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetNoWait(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureContainerRestartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings EnableNoWait(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureContainerRestartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings DisableNoWait(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureContainerRestartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ToggleNoWait(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetSubscription(this AzureContainerRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetSubscription(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetDebug(this AzureContainerRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetDebug(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetHelp(this AzureContainerRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetHelp(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetOutput(this AzureContainerRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetOutput(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetQuery(this AzureContainerRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetQuery(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings SetVerbose(this AzureContainerRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerRestartSettings ResetVerbose(this AzureContainerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetIds(this AzureContainerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetIds(this AzureContainerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings AddIds(this AzureContainerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings AddIds(this AzureContainerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ClearIds(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings RemoveIds(this AzureContainerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings RemoveIds(this AzureContainerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetName(this AzureContainerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetName(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetResourceGroup(this AzureContainerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetResourceGroup(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetSubscription(this AzureContainerShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetSubscription(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetDebug(this AzureContainerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetDebug(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetHelp(this AzureContainerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetHelp(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetOutput(this AzureContainerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetOutput(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetQuery(this AzureContainerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetQuery(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings SetVerbose(this AzureContainerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerShowSettings ResetVerbose(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerStartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerStartSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetName(this AzureContainerStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetName(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetResourceGroup(this AzureContainerStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetResourceGroup(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetNoWait(this AzureContainerStartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetNoWait(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureContainerStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings EnableNoWait(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureContainerStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings DisableNoWait(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureContainerStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ToggleNoWait(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetSubscription(this AzureContainerStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetSubscription(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetDebug(this AzureContainerStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetDebug(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetHelp(this AzureContainerStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetHelp(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetOutput(this AzureContainerStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetOutput(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetQuery(this AzureContainerStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetQuery(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings SetVerbose(this AzureContainerStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStartSettings ResetVerbose(this AzureContainerStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerStopSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetName(this AzureContainerStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Name"/></em></p>
        ///   <p>The name of the container group.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetName(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetResourceGroup(this AzureContainerStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetResourceGroup(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetSubscription(this AzureContainerStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetSubscription(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetDebug(this AzureContainerStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetDebug(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetHelp(this AzureContainerStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetHelp(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetOutput(this AzureContainerStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetOutput(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetQuery(this AzureContainerStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetQuery(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureContainerStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings SetVerbose(this AzureContainerStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureContainerStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureContainerStopSettings ResetVerbose(this AzureContainerStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ContainerCreateIpAddress
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ContainerCreateIpAddress>))]
    public partial class ContainerCreateIpAddress : Enumeration
    {
        public static ContainerCreateIpAddress private_ = new ContainerCreateIpAddress { Value = "private" };
        public static ContainerCreateIpAddress public_ = new ContainerCreateIpAddress { Value = "public" };
    }
    #endregion
    #region ContainerCreateOsType
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ContainerCreateOsType>))]
    public partial class ContainerCreateOsType : Enumeration
    {
        public static ContainerCreateOsType linux = new ContainerCreateOsType { Value = "linux" };
        public static ContainerCreateOsType windows = new ContainerCreateOsType { Value = "windows" };
    }
    #endregion
    #region ContainerCreateProtocol
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ContainerCreateProtocol>))]
    public partial class ContainerCreateProtocol : Enumeration
    {
        public static ContainerCreateProtocol tcp = new ContainerCreateProtocol { Value = "tcp" };
        public static ContainerCreateProtocol udp = new ContainerCreateProtocol { Value = "udp" };
    }
    #endregion
    #region ContainerCreateRestartPolicy
    /// <summary>
    ///   Used within <see cref="AzureContainerTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ContainerCreateRestartPolicy>))]
    public partial class ContainerCreateRestartPolicy : Enumeration
    {
        public static ContainerCreateRestartPolicy always = new ContainerCreateRestartPolicy { Value = "always" };
        public static ContainerCreateRestartPolicy never = new ContainerCreateRestartPolicy { Value = "never" };
        public static ContainerCreateRestartPolicy onfailure = new ContainerCreateRestartPolicy { Value = "onfailure" };
    }
    #endregion
}

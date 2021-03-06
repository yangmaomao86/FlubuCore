﻿using System;

namespace FlubuCore.Context
{
    public static class BuildProps
    {
        public const string OSPlatform = "os_platform";
        public const string BuildVersion = "build_version";

        /// <summary>
        /// Build version quality (build version suffix).
        /// </summary>
        [Obsolete("Use 'BuildVersion' constant instead", true)]
        public const string BuildVersionQuality = "build_version_quality";

        [Obsolete("Use 'BuildVersion' constant instead", true)]
        public const string BuildVersionWithQuality = "build_version_with_quality";

        public const string BuildConfiguration = "build_configuration";

        [Obsolete("Constant was moved to DotNetBuildProps.CompanyCopyright", true)]
        public const string CompanyCopyright = "company_copyright";

        [Obsolete("Constant was moved to DotNetBuildProps.CompanyName", true)]
        public const string CompanyName = "company_name";

        [Obsolete("Constant was moved too DotNetBuildProps.CompanyTrademark", true)]
        public const string CompanyTrademark = "company_trademark";
        public const string ProductId = "product_id";

        [Obsolete("Constant was moved to DotNetBuildProps.ProductName", true)]
        public const string ProductName = "product_name";
        public const string ProductRootDir = "product_root_dir";

        [Obsolete("Constant was moved to DotNetBuildProps.AutoAssemblyInfo", true)]
        public const string AutoAssemblyVersion = "auto_assembly_version";

        [Obsolete("Constant was moved too DotNetBuildProps.InformationalVersion", true)]
        public const string InformationalVersion = "informational_version";

        [Obsolete("Constant was moved too DotNetBuildProps.ProductVersionFieldCount", true)]
        public const string ProductVersionFieldCount = "product_version_field_count";

        public const string DotNetExecutable = "dotnet_executable";

        public const string NodeExecutablePath = "node_executable_path";
        [Obsolete("Use UserProfileFolder insted. Predefined value is the same.", true)]
        public const string UserHomeFolder = "user_home_folder";

        public const string UserProfileFolder = "user_profile_folder";
        public const string NpmPath = "npm_path";

        public const string SolutionFileName = "solution_file_name";
        public const string Solution = "solution";
        public const string NUnitConsolePath = "nunit_console_path";
        public const string XUnitConsolePath = "xunit_console_path";

        [Obsolete("Constant was moved to DotNetBuildProps.BuildDir")]
        public const string BuildDir = "build_dir";

        [Obsolete("Constant was moved too DotNetBuildProps.OutputDir", true)]
        public const string OutputDir = "output_dir";
        public const string FlubuWebApiBaseUrl = "webapi_url";

        [Obsolete("Constant was moved too DotNetBuildProps.DefaultTargets", true)]
        public const string DefaultTargets = "default_targets";

        public const string IsWebApi = "is_webapi";

        public const string SqlCmdExecutable = "sqlcmd_executable";

        internal const string LastWebApiBaseUrl = "LastWebApiBaseUrl";
    }
}
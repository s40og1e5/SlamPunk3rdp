// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SlamPunk3rdp : ModuleRules
{
	public SlamPunk3rdp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SlamPunk3rdp",
			"SlamPunk3rdp/Variant_Platforming",
			"SlamPunk3rdp/Variant_Platforming/Animation",
			"SlamPunk3rdp/Variant_Combat",
			"SlamPunk3rdp/Variant_Combat/AI",
			"SlamPunk3rdp/Variant_Combat/Animation",
			"SlamPunk3rdp/Variant_Combat/Gameplay",
			"SlamPunk3rdp/Variant_Combat/Interfaces",
			"SlamPunk3rdp/Variant_Combat/UI",
			"SlamPunk3rdp/Variant_SideScrolling",
			"SlamPunk3rdp/Variant_SideScrolling/AI",
			"SlamPunk3rdp/Variant_SideScrolling/Gameplay",
			"SlamPunk3rdp/Variant_SideScrolling/Interfaces",
			"SlamPunk3rdp/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SanwuBPGraphShot : ModuleRules
{
	public SanwuBPGraphShot(TargetInfo Target)
	{
		
		PublicIncludePaths.AddRange(
			new string[] {
				"SanwuBPGraphShot/Public"
			});
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"SanwuBPGraphShot/Private",
                "Runtime/Slate/Private/Framework/Docking"
            });
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "Kismet",
                "MainFrame",
                "Slate",
                "UnrealEd"
			});
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Projects",
				"InputCore",
				"UnrealEd",
				"LevelEditor",
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
                "UnrealEd"
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			});
	}
}

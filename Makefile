.PHONY: dotnet-build
dotnet-build:
	dotnet build dotnet/dotnet.sln

.PHONY: dotnet-pack
dotnet-pack:
	dotnet pack dotnet/dotnet.sln --configuration Release

.PHONY: dotnet-clean
dotnet-clean:
	dotnet clean dotnet/dotnet.sln --configuration Release
	rm -rf dotnet/HelloDemoLibrary/bin/

.PHONY: dotnet-push
dotnet-push: dotnet-pack
	@dotnet nuget push dotnet/HelloDemoLibrary/bin/Release/*.nupkg  --source https://api.nuget.org/v3/index.json --api-key $(shell cat .secrets/nuget-key.secret)

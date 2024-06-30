# Fusionary BigCommerce

BigCommerce API Client for DotNet

## Publishing Packages

1. Push Branch
2. Add Tag (if you don't add a tag, this will build preview packages)
3. Build Packages

## Publish a BigCommerce Package

Add a Nuget.config file at ~/.nuget/NuGet/NuGet.Config with the following information

    <packageSources>
        ...
        <add key="github" value="https://nuget.pkg.github.com/fusionary/index.json" />
    </packageSources>
    <packageSourceCredentials>
        <github>
            <add key="Username" value="your_gh_username" />
            <add key="ClearTextPassword" value="your_ghp_token" />
        </github>
    </packageSourceCredentials>

See [Package Feed Setup Guide](https://fusionary.clickup.com/25630900/v/dc/re65m-5062) if you need to crate a GitHub
Personal Access Token

```shell
cd ./Fusionary.BigCommerce
```

(run in project directory)

```shell
dotnet pack Fusionary.BigCommerce.csproj --configuration Release
dotnet nuget push "**/*.nupkg" --skip-duplicate
```

(run this to cleanup left overs)

```
rm -rf ./**/*.nupkg
```
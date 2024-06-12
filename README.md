## Tombola.IdentityModel.OidcClient, a fork of IdentityModel.OidcClient
This fork exists so that we can use `IdentityModel.OidcClient` in .NET Framework, but add additional features when we consume it.
Some of the types inside the package were too restrictive for us to be able to do this.

### Branches
Due to this being a fork of a public repository, the `main` branch is left as it is upstream, with the upstream set to `IdentityModel.OidcClient:main`.
Releases are made from the repository's default branch, `tombola-release`, and pull requests should target this branch.
`main` should only be used to pull new versions from the upstream; changes from `main` should then be brought to `tombola-release` via a pull request.

# C#/NetStandard OpenID Connect Client Library for native Applications
Supported platforms: netstandard14, desktop .NET, UWP, .NET Core, Xamarin iOS & Android. [Nuget.](https://www.nuget.org/packages/IdentityModel.OidcClient/)

![openid_certified](https://cloud.githubusercontent.com/assets/1454075/7611268/4d19de32-f97b-11e4-895b-31b2455a7ca6.png)

See [here](https://identitymodel.readthedocs.io/en/latest/native/overview.html) for documentation and [here](https://github.com/IdentityModel/IdentityModel.OidcClient.Samples) for samples.

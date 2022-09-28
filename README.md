# CommandsNx

This project was generated using [Nx](https://nx.dev).

<p style="text-align: center;"><img src="https://raw.githubusercontent.com/nrwl/nx/master/images/nx-logo.png" width="450"></p>

🔎 **Smart, Fast and Extensible Build System**

## Adding .NET capabilities to your workspace

Nx supports many plugins which add capabilities for developing different types of applications and different tools.

These capabilities include generating applications, libraries, etc as well as the devtools to test, and build projects as well.

Below are our plugins:

- [.NET](https://docs.microsoft.com/en-us/dotnet/)
  - `npm install --save-dev @nx-dotnet/core`

There are also many other [community plugins](https://nx.dev/nx-community) you could add.

## Generate an application

Run `nx g @nx-dotnet/core:app my-app` to generate an application.

When using Nx, you can create multiple applications and libraries in the same workspace.

## Generate a library

Run `nx g @nx-dotnet/core:lib my-lib` to generate a library.

Libraries are shareable across libraries and applications.

## Development server

Run `nx serve my-app` for a dev server. The app will automatically reload if you change any of the source files.

<!--
## Code scaffolding

Run `nx g @nrwl/react:component my-component --project=my-app` to generate a new component.
-->

## Build

Run `nx build my-app` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Serve

Run `nx serve my-app` to run a simple development server. This will watch for file changes and rebuild your project.

## Understand your workspace

Run `nx dep-graph` to see a diagram of the dependencies of your projects.

## Contributing

Check out our [Contributors Guide](CONTRIBUTING.md)

## Further help

Visit the [Documentation](https://nx-dotnet.com/docs) to learn more.

## ☁ Nx Cloud

### Distributed Computation Caching & Distributed Task Execution

<p style="text-align: center;"><img src="https://raw.githubusercontent.com/nrwl/nx/master/images/nx-cloud-card.png"></p>

Nx Cloud pairs with Nx in order to enable you to build and test code more rapidly, by up to 10 times. Even teams that are new to Nx can connect to Nx Cloud and start saving time instantly.

Teams using Nx gain the advantage of building full-stack applications with their preferred framework alongside Nx’s advanced code generation and project dependency graph, plus a unified experience for both frontend and backend developers.

Visit [Nx Cloud](https://nx.app/) to learn more.

# DependencyInjection1
This project originates from various articles about dependecy injection in c#
The intention is to show a code example of how Microsofts generic host handles dependency injection.

## Dependency Injection
Dependency Injection is a design principle that uses the strategy pattern to make the components in the design loosely coupled.
The dependency between components is inserted from an injector component at runtime, hence build dependecies are removed.
With the build dependencies removed the components can be developed independent from each other.

## Generic Host
Microsoft provides a generic host that handles dependency injection 
For .Net core 3.1 the generic host is part of the Microsoft.Extension.Hosting package.

The Host class is a convinence class for creating the HostBuilder.
The HostBuilder configures, creates and initializes the generic host. 

## Installation
TODO: Describe the installation process
## Usage
TODO: Write usage instructions
## Contributing
1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D
## History
TODO: Write history
## Credits
TODO: Write credits
## License
TODO: Write license

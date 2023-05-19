# OutSystems Developer Cloud External Logic Template

This repository contains a dotnet new template for OutSystems Developer Cloud External Logic.

To install

- Clone this repository
- Change into odc-externallogic-template path

Run the following command

```
dotnet new install .\
```

This adds a new dotnet template **ODC External Logic Library** with a shortname **ODC**

To create a new solution run the following command

```
dotnet new odc --name <YourSolutionName>
```

This creates a new folder _YourSolutionName_ containing a solution with two projects.

- The library project
- A NUnit testproject

with a sample action **Echo**

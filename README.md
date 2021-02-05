# Bogus.Premium.Test
An example project setup for testing Bogus Premium.

* **Step 1**. Clone the project to your computer.
* **Step 2**. Add your license to the `Bogus.Premum.LicenseKey` file.  
  Your license key file should have two lines:  
  Line 1) Your registration name  
  Line 2) The digital signature for payment
  ```
  Brian Chavez
  fazow2AwoaweAwa...
  ``` 

* **Step 3**. Execute the following commands in the **Visual Studio 2019 Developer Command Prompt**:
  ```
  R:\>cd Bogus.Premium.Test
  ```
  ```
  R:\Bogus.Premium.Test>dotnet build
  Microsoft (R) Build Engine version 16.7.2+b60ddb6f4 for .NET
  Copyright (C) Microsoft Corporation. All rights reserved.
  
    Determining projects to restore...
    Restored R:\Bogus.Premium.Test\Bogus.Premium.Test.csproj (in 248 ms).
    Bogus.Premium.Test -> R:\Bogus.Premium.Test\bin\Debug\netcoreapp3.1\Bogus.Premium.Test.dll
  
  Build succeeded.
      0 Warning(s)
      0 Error(s)
  
  Time Elapsed 00:00:02.22
  ```
  ```
  R:\Bogus.Premium.Test>dotnet run
  Hello Bogus!
  ```

* **Step 4**. Open the `Bogus.Premium.Test.sln` solution file in **Visual Studio 2019**. 
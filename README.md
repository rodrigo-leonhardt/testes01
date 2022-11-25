# Exemplo de testes de unidade


--Crie um projeto de testes
dotnet new xunit

--Adicione o projeto como dependência
dotnet add reference ./PrimeService/PrimeService.csproj

--Run the tests in the project in the current directory, and log with detailed verbosity to the console
dotnet test --logger "console;verbosity=detailed"

--Arrange, Act, Assert
Arrange: Set up the test.
Act: Execute the test.
Assert: Verify the results.


https://www.c-sharpcorner.com/article/unit-testing-using-xunit-and-moq-in-asp-net-core/
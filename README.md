
<h1 style="font-weight:bold"> TurboBidArena </h1>

![image](https://github.com/user-attachments/assets/57eb5280-aa54-407d-9b82-86d2f2c11961)

<p>Project Architecture </p>

![image](https://github.com/user-attachments/assets/30bf5055-986b-4730-800b-0fd1050c9ec0)
<p>Ref:revdebug</p>

![image](https://github.com/user-attachments/assets/3d27bc77-7a01-4999-96e1-e3b8d6b06930)

Section 02: Creating the first Microservice 

dotnet --info
  clear
  dotnet new list
  dotnet new sln
  ls
  mkdir TurboBidArena
  cd TurboBidArena
  dotnet new sln
  ls
s  dotnet new webapi -o src/AuctionService -controllers
dotnet sln add src/AuctionService
Project `src\AuctionService\AuctionService.csproj` added to the solution.


Running DotNet Application:
	cd src/AuctionService
	dotnet watch

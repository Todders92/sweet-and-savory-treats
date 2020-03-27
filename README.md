# Pierre's Sweet and Savory Treats
#### March 27, 2020

ASP.NET core MVC application using Entity Framework Core and MySQL for a Pastry Shop Manager. This appilication allows the user to fill out forms to keep track of treats and flavors.

### Prerequisites

1. _Net Core SDK, install instructions can be found [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)_
2. _dotnet script, install instructions can be found [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script)_


### Installing

1. Clone the repository:
    ```
    git clone https://github.com/todders92/sweet-and-savory-treats
    ```
2. Change directories into the project working directory:
    ```
    cd SavoryTreats.Solution/SavoryTreats
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```

#### Database Setup

4. Setup the database through the terminal:
    ```
    dotnet ef migrations add Initial
    ```
4. Update the database:
    ```
    dotnet ef database update
    ```
5. Compile and Run code:
    ```
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```


### BDD Specifications

|Behavior|Input|Output|
|:-:|:-:|:-:|
|User visits main page, user can click a link to treats page|visits '/'|Redirect to '/treats'|
|User clicks 'Add treats' button, redirect to New treats form|clicks 'Add treats'|Redirect to '/treats/new' and show New treats form|
|User clicks 'Submit' on New treats form, add new treats to DB and redirect to Index route of Treats|clicks 'submit' on New treats form|**Create new treats in DB**, Redirect to '/treats'|
|User clicks on a treats in the Index route of Treats, show details of that treats|clicks on 'Kris' (id = 2)|Redirect to '/treats/2', show all details of Kris|
|User clicks 'Add Flavor' button, redirect to New Flavor form|clicks 'Add flavor'|Redirect to '/treats/{id}/flavors/new' and show New Flavor form|
|User clicks 'Submit' on New Flavor form, add new flavor to DB and redirect to Details route of treats|clicks 'submit' on New Flavor form|**Create new Flavor in DB**, Redirect to '/treats/{id}'|
|User clicks on a flavor in the Details route of a specific treats, show details of that flavor|clicks on 'Ross' (id = 4)|Redirec to '/treats/{id}/flavors/4', show all details of Ross|
|User clicks 'Delete' button on a treats in the Index page of Treats, delete specific treats and redirect to Index|clicks 'Delete'|**Delete treats from DB**, redirect to '/treats'|
|User clicks 'Edit' button on a treats in the Details page, Redirect to Edit form for specific treats.|clicks 'Edit'|Redirect to '/treats/{id}/edit', show treats Edit form|
|User clicks 'Submit' button on treats edit form, Update details of treats in DB and redirect to Details of treats|clicks 'submit'|**Update Stylist in DB**, redirect to '/treats/{id}'|


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* MySQL/MySQL Workbench
* RESTful Routing
* CRUD Functionality
* Git

## Authors

* **Todd Walraven** - (https://github.com/todders92)

## License

Licensed under the MIT license.

&copy; 2020 - Todd Walraven
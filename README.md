# Technical Service Application

This project provides an example of a Technical Service Application developed using a Windows Forms application with DevExpress control library.

## Features

- Includes a login screen (`FrmLogin`) for users to authenticate.
- The main application window (`FrmMain`) contains a menu and tab interface allowing users to navigate and manage different functionalities.
- The application uses separate tab pages to manage users, settings, maintenance records, devices, personnel, and departments.
- Each tab page contains a user control providing the relevant functionality.
- Includes functionality to save changes to the database.

## Usage

1. Open the project in Visual Studio or a similar IDE.
2. Install and add DevExpress components to the project.
3. Compile and run the project.
4. Enter the username and password to log in to the application.
5. Access different tab pages by selecting the desired functionality from the menu.
6. Click the "Save" button to save any changes made.

## Requirements

- .NET Framework
- DevExpress Controls
- Visual Studio IDE

## TSA.Model

The TSA.Model project contains the data models used in the Technical Service Application (TSA) application. These models correspond to database tables and are used in the application's data layer.

### BaseModel Class

The BaseModel class forms the basis for other model classes. This class tracks who created a record, when it was created, who last updated it, and when it was last updated.

#### Properties

1. **CreatedByUserId:**
   - ID of the user who created the record.
   
2. **CreationDate:**
   - Date and time when the record was created.
   
3. **UpdatedByUserId:**
   - ID of the user who last updated the record.
   
4. **UpdateDate:**
   - Date and time when the record was last updated.

#### Other Model Classes

1. **TblDepartment:**
   - Stores information related to departments.
   
2. **TblDevice:**
   - Stores information related to devices.
   
3. **TblDeviceType:**
   - Stores information related to device types.
   
4. **TblMaintenanceRecord:**
   - Stores information related to maintenance records.
   
5. **TblPersonnel:**
   - Stores information related to personnel.
   
6. **TblUser:**
   - Stores information related to users.

Each model class defines the fields and relationships of the corresponding table.

## TSA.Service

The TSA.Service project provides the service layer of the Technical Service Application (TSA) application. This layer handles database operations and data management.

### DbService Class

#### Methods

1. **Save():**
   - Saves changes made in the database.

2. **GetUsers():**
   - Retrieves all users from the database.

3. **GetBindingUsers():**
   - Retrieves all users from the database as a binding list.

4. **DeleteUser(TblUser user):**
   - Deletes the specified user from the database.

5. **Login(string username, string password):**
   - Validates user login.

6. **GetBindingMaintenance():**
   - Retrieves all maintenance records from the database as a binding list.

7. **GetBindingDevices():**
   - Retrieves all devices from the database as a binding list.

8. **GetBindingPersonnels():**
   - Retrieves all personnels from the database as a binding list.

9. **GetBindingDeviceTypes():**
   - Retrieves all device types from the database as a binding list.

10. **GetBindingDepartments():**
    - Retrieves all departments from the database as a binding list.

### Usage

This class is used to perform database operations. It facilitates access to the database and operations such as adding, deleting, updating, and querying data.

## TSA.App

The TSA.App project contains the code related to the user interface of the Technical Service Application (TSA) application. In this project, users can log in to the application and perform various operations.

### FrmLogin Form

The FrmLogin form is a user interface used to log in to the TSA application. In this form, users enter their username and password to perform the login process.

#### Controls

1. **txtUsername:**
   - Text box for entering the username.

2. **txtPassword:**
   - Text box for entering the password. Password characters are displayed as '*' for security.

3. **btnLogin:**
   - Login button. Performs the login process if the username and password are correct.

4. **lblInfo:**
   - Information label. Displays information messages if the username or password is incorrect.

#### FrmLogin Class

The FrmLogin class represents a Windows Form derived from the XtraForm class. This class contains the design of the user interface and the login process.

### FrmLogin Code

The FrmLogin class contains the code that performs the login process in addition to the user interface. Users enter their username and password during login, and this information is verified in the database. If the authentication process is successful, the main application window opens; otherwise, an error message is displayed to the user.


# [btk_tsa_db] Database

## Purpose

[btk_tsa_db] is a database for a supply chain management system. This database includes fundamental components such as devices, personnel, departments, and maintenance records. Additionally, it provides a table for managing user credentials and authorization levels.

## Tables

1. **Departments**:
   - Stores information about departments.
   - Columns: Id, Name, CreatedByUserId, CreationDate, UpdatedByUserId, UpdateDate.

2. **Devices**:
   - Stores information about devices.
   - Columns: Id, Name, TypeId, Description, PurchaseDate, AssignedPersonnelId, AssignDate, CreatedByUserId, CreationDate, UpdatedByUserId, UpdateDate.

3. **DeviceTypes**:
   - Stores information about device types.
   - Columns: Id, Name, CreatedByUserId, CreationDate, UpdatedByUserId, UpdateDate.

4. **MaintenanceRecords**:
   - Stores maintenance records.
   - Columns: Id, DeviceId, UserId, MaintenanceType, MaintenanceDate, Explanation, CreatedByUserId, CreationDate, UpdatedByUserId, UpdateDate.

5. **Personnels**:
   - Stores personnel information.
   - Columns: Id, Name, Surname, DepartmentId, CreatedByUserId, CreationDate, UpdatedByUserId, UpdateDate.

6. **Users**:
   - Stores user credentials and authorization levels.
   - Columns: Id, Username, Password, Name, Surname, Authorization, CreatedByUserId, CreationDate, UpdatedByUserId, UpdateDate.

## Screenshots

![Database_Diagram](https://github.com/Fuat47/Technical_Service_Application/assets/82528882/3a311d75-27be-438c-8e53-526243ad0839)
![Login](https://github.com/Fuat47/Technical_Service_Application/assets/82528882/b4dfa43e-4058-4c76-ae7b-4e1fd0f927ce)
![User_Page](https://github.com/Fuat47/Technical_Service_Application/assets/82528882/f50840d2-58f8-4ec2-b71a-4874c38d0d17)
![Maintenance_Records](https://github.com/Fuat47/Technical_Service_Application/assets/82528882/0dc6287e-93e7-49fd-a480-dc30607b37d9)




---

This README file combines the information from the Database, TSA.Model, TSA.Service, and TSA.App projects. It explains the data models, service layer functionalities, and user interface components used in the Technical Service Application (TSA) application.


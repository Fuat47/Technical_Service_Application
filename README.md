# TechnicalServiceApplication






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

## Screenshot

![Database_Diagram](https://github.com/Fuat47/Technical_Service_Application/assets/82528882/3a311d75-27be-438c-8e53-526243ad0839)


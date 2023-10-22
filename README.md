# DeliArg
This solution will allow DeliArg to manage the stock of its products in various warehouses and stores, including supplier orders.

## **About the solution**
The backend is in a single project, to keep the configurations simple and focus on the use of Blazor as a frontend technology.
When developing the solution I took into account the following concepts:

- SOLID principles
   - Single responsibility principle
   - Open/closed principle
   - Liskov substitution principle
   - Interface segregation principle
   - Dependency inversion principle
- DRY (Don't Repeat Yourself)
- YAGNI (You Aren't Gonna Need It)

I also used the following methodologies:

- C# Coding conventions (https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Conventional commits (https://www.conventionalcommits.org/en/v1.0.0/)

## **Tools**

Development tools, frameworks and libraries used:

- Visual Studio 2022
- .NET 7 (WebApi and Blazor)
- Swagger
- AutoMapper
- Entity Framework Core
- Postman

## **Analysis and development process**

The user stories that I developed, in addition to the CRUD of the entities, are:

- ~~As a store manager, I want to order products from warehouses.~~
- ~~As a warehouse manager, I want to order products to suppliers.~~

### **Entity relationship diagram**
```mermaid
erDiagram
Supplier ||--|{ ProductSupplier : has
ProductSupplier }|--|| Product : has
Supplier ||--|{ Order : has
Order ||--|{ OrderItem : contains
Order }|--|| OrderStatus : has
Order }|--|| Warehouse : has
OrderItem }|--|| Product : has
Warehouse ||--|{ ShipmentReceipt : has
Product ||--|{ ShipmentReceiptItem : has
ShipmentReceipt ||--|{ ShipmentReceiptItem : contains
Product ||--|{ ProductStore : has
ProductStore }|--|| Store : has
Store ||--|{ ShipmentReceipt : has
ShipmentReceipt }|--|| ShipmentReceiptStatus : has

Supplier {
    int Id PK
    string Name
    string Address
}

ProductSupplier {
    int Id PK
    int SupplierId FK
    int ProductId FK
}

Product {
    int Id PK
    string Name
    string Description
    string PictureUrl
}

ProductStore {
    int Id PK
    int ProductId FK
    int StoreId FK
    float Price
    int Quantity
}

Order {
    int Id PK
    int SupplierId FK
    int OrderStatusId FK
    float TotalAmount
    date Date
}

OrderItem {
    int Id PK
    int OrderId FK
    int ProductId FK
    float Price
    int Quantity
}

OrderStatus {
    int Id PK
    string Description
}

Store {
    int Id PK
    string Name
    string Address
}

Warehouse {
    int Id PK
    string Name
    string Address
}

ShipmentReceipt {
    int Id PK
    int WarehouseId FK
    int StoreId FK
    int ShipmentReceiptStatusId FK
    date Date
}

ShipmentReceiptItem {
    int Id PK
    int ShipmentReceiptId FK
    int ProductId FK
    int Quantity
}

ShipmentReceiptStatus {
    int Id PK
    string Description
}
```

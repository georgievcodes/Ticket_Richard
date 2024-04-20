# Telerik UI ASP.NET Core - Demo

## Description

This project is demo displaying some functionalities of the Telerik UI for ASP.NET Core. The info is displayed in the grid Layout using a Grid component that has several built in functions like pagination and sorting. The data in the grid is filterable using external drop down list component.

## Components

### DataSource

The project utilize a custom `DataSource<OrderViewModel>()` that binds data from the `GridController` to a component and makes it available for all other components on the page.

**Example:**

```
@(Html.Kendo().DataSource<OrderViewModel>()
        .Name("myDataSource")
        .Ajax(dataSource => dataSource
          .Read(read => read.Action("Orders_Read", "Grid"))
        )
)
```

- `Name()` configuration method sets a name of the `DataSource`. This is mandatory as its value is used for element ID attribute.
- `Ajax()` method is used to enable Ajax functionality.
- `PageSize()` method sets up the items shown per page.
- `Read()` method is used to set the end point in this case we use it to specify an action and a controller to be called.

### Grid

The Grid is a powerful component displaying data in a tabular format. It provides options for grouping, sorting, pagind, filtering and more.

**Example:**

```
@(Html.Kendo().Grid<OrderViewModel>()
    .Name("grid")
    .Columns(columns =>
    {
        columns.Bound(p => p.OrderID).Filterable(false);
        columns.Bound(p => p.Freight);
        columns.Bound(p => p.OrderDate).Format("{0:MM/dd/yyyy}");
        columns.Bound(p => p.ShipName);
        columns.Bound(p => p.ShipCity);
    })
    .Pageable()
    .ColumnMenu()
    .Selectable(selectable => selectable
    .Mode(GridSelectionMode.Single)
    .Type(GridSelectionType.Row))
    .HtmlAttributes(new { style = "height:550px;" })
    .DataSource("myDataSource")
    )
```

- `Name()` sets a name for the Grid. This is mandatory as its value is used for element ID attribute.
- `Pageable()` method allows for data to be displayed in pages in the grid.  
  `PageSizes(new[] {int, int, int }` an extra option can be used to allow the user to pick a different amount of items per page.
- `Selectable()` method allows for control over grid
  selection supporting  
  `Mode()` allows for single and multi selection options.  
  `Type()` allows for rows or cells selection.
- `ColumnMenu()` method enables a selection menu which allows the changing of column visibility.
- `DataSource()` method is used to configure the data source of the grid. Since the data source is already set in its own component we can simly add its `Name()` value to the `DataSource()` directly.

### DropDownList

We use a `DropDownList()` component to filter the data in the Grid component externaly. In this case the DropDownList is dinamically updated with distinct values from the `ShipCity` property of the `OrderViewModel` collection.

**Example**

```
@(Html.Kendo().DropDownList()
    .Name("dropDownList")
    .DataSource(dataSource => dataSource
    .Read(read => read
    .Action("DropDownListData", "Grid")))
    .SelectedIndex(0)
    .HtmlAttributes(new { style = "width:200px;" })
    .OptionLabel("Show All")
    .Events(e => e.Change("onChange"))
    )
```

- As every other component we set the `Name()` of the DropDownList.
- `DataSource()` gets the data for the list from the Grid controller
- `SelectIndex()` used to set selected item index.
- `OptionLabel()` used to set up a placeholder item.
- `Events()` used to set up different events.  
  In this instance we use the `onChange(e)` event to trigger an event when an option is selected from the list.
- `Read()` method calls the `DropDownListData` action of the `Grid` controller where we set a list of distinked `ShipCity` values in order to provide dynamic filtering options for the `Grid` component.

### Scripts

In order to take advantage of set `Events()` in components we utilize jquery and JS scripts to read the event and perform an action depending on it.

**Example:**

```
function onChange(e) {
    var dataItem = this.dataItem(e.item);
    if (dataItem == "Show All") {
        dataItem = "";
    }
    $("#grid").data("kendoGrid").dataSource.filter({ field: "ShipCity", operator: "contains", value: dataItem });
    return;
}
```

Selecting an option in the `DropDownList` triggers its `onChange()` event.  
We use the function with the same name `onChange(e)` to catch the event and use the selected option value as a filter option for the `Grid` data.  
We apply the filter option using `JQuery` filter function on the `DataSource` of the `Grid`.  
Special case is added to take care of the `Show All` default option of the list, setting the `dateItem` value to an empty string remove the filtration from the `Grid` data.

# Client Email Response

Greetings Richard,

Sorry to hear that you have encountered issues. Our team strive to provide not only an excellent product, but also the tools needed to ensure a smooth and seamless product experience. I have passed your feedback to the team. We are thinking of ways to improve the articles related to Grid data-binding and external filtering to be more comprehensive so that they don't cause an issue for the next person using the docs.

On to the issue at hand. I have created a demo project with all the features you've mentioned. In the README file you can find extra info about the used components.

[Click this link to go the demo repository](https://github.com/georgievcodes/Ticket_Richard)

I hope the demo has all the info you require. Should any other issues or questions arise, feel free to contact us again, we are here to assist.  
In addition, you can check the next few links for extra info and functionalities you might want to add.

[Grid component](https://demos.telerik.com/aspnet-core/grid)  
[DropDownList component](https://demos.telerik.com/aspnet-core/dropdownlist)  
[DataSource component](https://demos.telerik.com/aspnet-core/datasource)

Regards,  
Georgi Georgiev - SupportTeam™

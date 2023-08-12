
# Creating

# Reading

### Data Access

- Set up the Data Access CS file in *SupportLibrary* > *DataAccess*
- Need a method for loading data
- Need a method for saving data
- Extract Interface
- Add service to `Program.cs`
  - `builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();`
- <mark>**TODO**</mark>
  - Determine best method
  - Async vs. not async
- <mark>**NOTE**</mark>
  - If using ASYNC / Stored Procedure, there must be a stored procedure
  - Can't use a SQL string
  - Have to publish the database again after creating the stored procedure

### Data (Data Service)

- Set up the Data Service CS file in *SupportLibrary* > *Data*
- Create method for querying the database using the DataAccess interface
- Extract Interface
- Add service to `Program.cs`
  - `builder.Services.AddScoped<IDataService, DataService>();`

# Updating

# Deleting
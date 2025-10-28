-- BANK AND BRANCH

CREATE TABLE Bank (
    BankID INT IDENTITY(1,1) PRIMARY KEY,
    BankName NVARCHAR(100) NOT NULL,
    EstablishedDate DATE NULL,
    Headquarters NVARCHAR(200) NULL,
    IsActive BIT DEFAULT 1
);

CREATE TABLE Branch (
    BranchID INT IDENTITY(1,1) PRIMARY KEY,
    BankID INT NOT NULL FOREIGN KEY REFERENCES Bank(BankID),
    BranchName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(250),
    City NVARCHAR(100),
    IFSCCode NVARCHAR(20) UNIQUE,
    ContactNumber NVARCHAR(20),
    IsActive BIT DEFAULT 1
);

-- ROLES & PERMISSIONS

CREATE TABLE Role (
    RoleID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(200)
);

CREATE TABLE Permission (
    PermissionID INT IDENTITY(1,1) PRIMARY KEY,
    PermissionName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(200)
);

CREATE TABLE RolePermission (
    RoleID INT NOT NULL FOREIGN KEY REFERENCES Role(RoleID),
    PermissionID INT NOT NULL FOREIGN KEY REFERENCES Permission(PermissionID),
    PRIMARY KEY (RoleID, PermissionID)
);

-- USERS

CREATE TABLE [User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    DOB DATE NULL,
    Email NVARCHAR(100) UNIQUE,
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(200),
    IsMinor BIT DEFAULT 0,
    CreatedDate DATETIME DEFAULT GETDATE(),
    ModifiedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

CREATE TABLE UserRole (
    UserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
    RoleID INT NOT NULL FOREIGN KEY REFERENCES Role(RoleID),
    PRIMARY KEY (UserID, RoleID)
);

-- ======================
-- EMPLOYEES
-- ======================
CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    BranchID INT NOT NULL FOREIGN KEY REFERENCES Branch(BranchID),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    PhoneNumber NVARCHAR(20),
    RoleID INT NOT NULL FOREIGN KEY REFERENCES Role(RoleID),
    HireDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

-- CURRENCY AND ACCOUNT TYPES

CREATE TABLE Currency (
    CurrencyCode CHAR(3) PRIMARY KEY,
    CurrencyName NVARCHAR(50) NOT NULL,
    Symbol NVARCHAR(10)
);

CREATE TABLE AccountType (
    AccountTypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(200)
);

-- ACCOUNTS

CREATE TABLE Account (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
    BranchID INT NOT NULL FOREIGN KEY REFERENCES Branch(BranchID),
    AccountTypeID INT NOT NULL FOREIGN KEY REFERENCES AccountType(AccountTypeID),
    CurrencyCode CHAR(3) NOT NULL FOREIGN KEY REFERENCES Currency(CurrencyCode),
    AccountNumber NVARCHAR(20) UNIQUE NOT NULL,
    Balance DECIMAL(18,2) DEFAULT 0.00,
    OpenDate DATETIME DEFAULT GETDATE(),
    CloseDate DATETIME NULL,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- POWER OF ATTORNEY

CREATE TABLE PowerOfAttorney (
    POAID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL FOREIGN KEY REFERENCES Account(AccountID),
    GrantedToUserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
    GrantedDate DATETIME DEFAULT GETDATE(),
    ExpiryDate DATETIME NULL,
    IsActive BIT DEFAULT 1
);

-- ACCOUNT OPERATORS (LIMITED ACCESS)

CREATE TABLE AccountOperator (
    OperatorID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL FOREIGN KEY REFERENCES Account(AccountID),
    OperatorUserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
    AccessLevel NVARCHAR(50) CHECK (AccessLevel IN ('ViewOnly', 'DepositOnly', 'DepositWithdrawLimited')),
    GrantedDate DATETIME DEFAULT GETDATE(),
    ExpiryDate DATETIME NULL,
    IsActive BIT DEFAULT 1
);

-- TRANSACTIONS

CREATE TABLE [Transaction] (
    TransactionID BIGINT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL FOREIGN KEY REFERENCES Account(AccountID),
    PerformedByUserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
    TransactionType NVARCHAR(20) CHECK (TransactionType IN ('Deposit', 'Withdrawal', 'BalanceCheck', 'Closure')),
    Amount DECIMAL(18,2) CHECK (Amount >= 0),
    CurrencyCode CHAR(3) NOT NULL FOREIGN KEY REFERENCES Currency(CurrencyCode),
    TransactionDate DATETIME DEFAULT GETDATE(),
    Remarks NVARCHAR(250)
);


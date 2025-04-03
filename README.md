# 🏥 Hospital Management System  

🚀 **Hospital Management System** is a powerful desktop application built using **C#, .NET Framework, Entity Framework Core, Dapper, and SQL Server** to manage hospital operations efficiently, including **patient management, doctor scheduling, appointments, and billing**.  

## 🔹 Key Features  

✅ **User Management** – Add, update, and remove users (Admins, Doctors, Receptionists).  
✅ **Patient Management** – Register patients, update records, and manage medical history.  
✅ **Doctor Management** – Add doctors, update their details, and manage schedules.  
✅ **Appointment System** – Book, edit, and cancel appointments.  
✅ **Billing System** – Generate invoices, track payments, and support multiple payment methods.  
✅ **Reports & Statistics** – Generate reports on patients, doctors, and appointments.  
✅ **Notification System** – Notify doctors **5 minutes** before their scheduled appointment via in-app notifications.  
✅ **Export Medical Records & Bills** – Allows exporting patient records and invoices in **Word or Excel** format.  
✅ **Late Fee for Overdue Payments** – Automatically applies a late fee if a payment is overdue.  
✅ **(Optional) Medical Device Integration** – Store digital medical test reports.  

## 🔹 Technology Stack  

- **Programming Language:** C#  
- **Framework:** .NET Framework, WinForms  
- **Database:** SQL Server  
- **ORM:** Entity Framework Core, Dapper  
- **Reporting:** DevExpress Reports  

## 🔹 Installation & Setup  

### 1️⃣ Prerequisites  
Before running the system, install:  
✅ Microsoft SQL Server  
✅ .NET Framework  
✅ Entity Framework Core & Dapper NuGet Packages  
✅ DevExpress Reports NuGet Package  

### 2️⃣ Database Setup (Code First)  
1. Open **Visual Studio** and navigate to **Package Manager Console**.  
2. Run the following command to create the database automatically:  
   ```powershell
   Update-Database
   ```  
3. Update the **Connection String** in the `App.config` file.  

### 3️⃣ Running the Application  
1. Open the project in **Visual Studio**.  
2. Click `Start` to run the application.  
3. Use the following default login credentials:  

| Role | Username | Password |  
|------|---------|----------|  
| Admin | `Ad.Ali` | `1234` |  
| Doctor | `Dr.Ahmed` | `1234` |  
| Receptionist | `Rec.AYAElz` | `1234` |  

## 🔹 Doctor Appointment Notifications  
- **5 minutes before an appointment**, the system will send a notification via:  
  ✅ **In-app notification** (A pop-up alert).  
## 🔹 Patient Appointment Notifications  
 the system will send a notification via:  
✅ **Email** (Must be configured in settings).   
## 🔹 Export Medical Records & Bills  
- Medical records and invoices can be exported in **Word** format for easy access and record-keeping.  

## 🔹 Late Fee for Overdue Payments  
- If a **bill's due date** has passed, a **late fee** will be added automatically.  
- The system will notify patients about overdue payments via email.  

## 🔹 Contributors  

🙌 Special thanks to all contributors who have helped build and improve this project!  

| Name | GitHub Profile | |
|------|--------------|------|
| **Ahmed Ali** | [@AhmedElshehamy](https://github.com/AhmedElshehamy)
| **Ali Mohamed Ali (Ali Abu Hussein)** | [@AbuHussien28](https://github.com/AbuHussien28) 
| **Aya Elzoghby** | [@Aya-Elzoghby21](https://github.com/Aya-Elzoghby21) 


> Want to contribute? Fork the repo and submit a Pull Request! 🚀  

## 🔹 Contribution  
💡 We welcome contributions! If you'd like to improve the project:  
1. **Fork** the repository.  
2. Create a new branch (`feature-branch`).  
3. Make your changes and submit a **Pull Request**.  

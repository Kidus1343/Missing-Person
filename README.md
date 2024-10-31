# Missing-Person

The **Missing-Person** project is a web application built with ASP.NET Core, designed to assist in locating individuals who have gone missing. This platform allows users, such as friends, family members, or law enforcement, to submit and access information on missing individuals. The application supports sending emails to various providers like Gmail through SMTP, enabling quick communication with authorities or relevant contacts.

## Features

- **Contact Us Page**  
  Developed using ASP.NET Core with dependency injection, allowing seamless email communication across different email providers (e.g., Gmail). This setup enables prompt responses and inquiries about missing individuals, which can be critical in time-sensitive cases.

- **Data Submission and Retrieval**  
  Individuals can enter and submit details about missing persons. This information can then be retrieved by authorized personnel, including police or other individuals, to assist in the search and identification process.

- **Backend Architecture**  
  Built with ASP.NET Core, using C#, Razor, LINQ for querying, and CSHTML, the system ensures a reliable and efficient backend. Data handling is optimized to maintain high responsiveness, enhancing user experience.

## Technologies Used

- **ASP.NET Core**: Provides a robust, scalable platform for handling web application requests.
- **C#**: The main programming language for backend logic.
- **Razor & CSHTML**: For building dynamic and responsive pages.
- **LINQ**: To handle and query data efficiently.
- **Dependency Injection**: Used to manage email communication, allowing the application to interface with different email providers via SMTP.

## Installation and Setup

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or any preferred SQL database
- Email provider credentials (e.g., Gmail) to set up SMTP

### Steps to Install and Run

1. **Clone the Repository**
   ```bash
   git clone https://github.com/YourUsername/Missing-Person.git
   cd Missing-Person
2. Configure Email Settings
In appsettings.json, set up SMTP details to enable email communication:
"EmailSettings": {
    "SmtpServer": "smtp.gmail.com",
    "SmtpPort": 587,
    "SenderName": "Your Name",
    "SenderEmail": "your-email@gmail.com",
    "SenderPassword": "your-email-password"
}

Run the Application

bash
Copy code
dotnet run
The application will be available at https://localhost:5001.

Usage
Adding Missing Person Data
Users can submit details of a missing individual, including their name, age, and physical description, as well as the circumstances of their disappearance.

Contact Us for Inquiries
Users can reach out via the Contact Us page, where dependency injection allows for efficient email routing to different providers using SMTP. This functionality can notify relevant personnel about new missing person entries or inquiries regarding ongoing cases.

Contribution
Contributions are welcome! Please follow these steps:

Fork the repository.
Create a new branch for your feature (git checkout -b feature/AmazingFeature).
Commit your changes (git commit -m 'Add some AmazingFeature').
Push to the branch (git push origin feature/AmazingFeature).
Open a pull request.
License
This project is licensed under the MIT License.

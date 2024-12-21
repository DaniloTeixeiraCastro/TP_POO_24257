# Tourist Accommodation System

## Overview

The Tourist Accommodation System is a Windows Forms application developed in C# for managing tourist accommodations. It provides a comprehensive platform for handling clients, reservations, accommodations, payments, and reviews, offering an intuitive interface for administrators and users alike.

## Key Features

### Clients Management
- Add, edit, and remove clients.
- View client details such as name, email, phone, date of birth, and tax identification number (TIN).
- Automated data validation:
  - Minimum age check (18+).
  - Email format validation.

### Accommodation Management
- Add, edit, and remove accommodations.
- Manage accommodation availability status (e.g., available, occupied).
- Filter accommodations by type, status, and price.

### Reservations
- Add, edit, and cancel reservations.
- Automatically select available accommodations based on check-in and check-out dates.
- Calculate total price based on the number of nights and price per night.

### Payments
- Record payments via multiple methods: cash, credit/debit card, and bank transfer.
- Manage payment statuses (pending, completed, refunded).

### Reviews
- Add reviews with optional anonymity.
- Rate accommodations on a scale of 1 to 5 stars.
- View reviews, including client comments and ratings.

## Project Structure

```
TouristAccommodationSystem/
│
├── Models/
│   Contains the main system classes:
│   - `Client.cs`: Represents system clients.
│   - `Accommodation.cs`: Represents available accommodations.
│   - `Reservation.cs`: Represents reservations made by clients.
│   - `Review.cs`: Represents client or anonymous reviews.
│   - `Entity.cs`: Base class for ID management.
│
├── Services/
│   Contains business logic and data manipulation:
│   - `ClientService.cs`: Handles client management.
│   - `AccommodationService.cs`: Handles accommodation management.
│   - `ReservationService.cs`: Handles reservation management.
│   - `ReviewService.cs`: Handles review management.
│   - `PaymentService.cs`: Handles payment management.
│
├── Forms/
│   User interface forms:
│   - `MainWindow.cs`: Main system window.
│   - `ReservationManagementForm.cs`: Manages reservations.
│   - `FormAddEditReservation.cs`: Form for adding/editing reservations.
│   - `FormAddEditReview.cs`: Form for adding/editing reviews.
│   - `ClientList.cs`: Displays a list of clients.
│
├── Enums/
│   Enum definitions used in the system:
│   - `AccommodationType.cs`: Defines accommodation types (e.g., garden view, pool view).
│   - `PaymentStatus.cs`: Defines payment statuses (e.g., pending, completed).
│   - `ReviewRating.cs`: Defines review ratings (1 to 5 stars).
│
├── Data/
│   JSON files for data storage:
│   - `clients.json`
│   - `accommodations.json`
│   - `reservations.json`
│   - `reviews.json`
│   - `payments.json`
│
├── Program.cs
├── README.md
└── .gitignore
```

## Technology Stack

- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Data Storage**: JSON files for lightweight and portable data persistence.

## Usage Instructions

### Adding a Client
1. Navigate to the **Clients** section in the main dashboard.
2. Click **Add Client** and fill out the required details.
3. Click **Save** to confirm.

### Making a Reservation
1. Go to the **Reservations** section.
2. Select a client and accommodation.
3. Specify the check-in and check-out dates.
4. Confirm the reservation to calculate the total price and save.

### Recording a Payment
1. Open the **Payments** section.
2. Choose a reservation and input payment details.
3. Set the payment method and status.
4. Save the payment record.

## Future Enhancements

- **Modernized UI**: Update the Windows Forms design for a more user-friendly interface.
- **Database Integration**: Migrate from JSON to a relational database (e.g., SQL Server) for improved scalability.
- **Authentication**: Add user login functionality to secure access.
- **Advanced Reporting**: Include dashboards for detailed analytics and insights.

## Author
Danilo Castro  
[GitHub Repository](https://github.com/DaniloTeixeiraCastro/TP_POO_25457)
Tourist Accommodation System

*Overview*

The Tourist Accommodation System is a Windows Forms application developed in C# for managing tourist accommodations. It provides a comprehensive platform for handling clients, reservations, accommodations, payments, and reviews, offering an intuitive interface for administrators and users alike.

*Key Features*

	*Clients Management*
- Add, edit, and remove clients.
- View client details such as name, email, phone, date of birth, and tax identification number (TIN).
- Automated data validation:
- Minimum age check (18+).
- Email format validation.

	*Accommodation Management*

- Add, edit, and remove accommodations.
- Manage accommodation availability status (e.g., available, occupied).
- Filter accommodations by type, status, and price.

	*Reservations*

- Add, edit, and cancel reservations.
- Automatically select available accommodations based on check-in and check-out dates.
- Calculate total price based on the number of nights and price per night.

	*Payments*

-Record payments via multiple methods: cash, credit/debit card, and bank transfer.
-Manage payment statuses (pending, completed, refunded).

	*Reviews*

- Add reviews with optional anonymity.
- Rate accommodations on a scale of 1 to 5 stars.
- View reviews, including client comments and ratings.

TouristAccommodationSystem/
│
├── Models/
│   Contém as classes principais do sistema:
│   - `Client.cs`: Representa os clientes do sistema.
│   - `Accommodation.cs`: Representa os alojamentos disponíveis.
│   - `Reservation.cs`: Representa as reservas feitas.
│   - `Review.cs`: Representa as avaliações feitas por clientes ou anônimas.
│   - `Entity.cs`: Classe base para gestão de IDs.
│
├── Services/
│   Contém a lógica de negócio e manipulação de dados:
│   - `ClientService.cs`: Gestão de clientes.
│   - `AccommodationService.cs`: Gestão de acomodações.
│   - `ReservationService.cs`: Gestão de reservas.
│   - `ReviewService.cs`: Gestão de avaliações.
│   - `PaymentService.cs`: Gestão de pagamentos.
│
├── Forms/
│   Formulários para interação com o utilizador:
│   - `MainWindow.cs`: Janela principal do sistema.
│   - `ReservationManagementForm.cs`: Gestão de reservas.
│   - `FormAddEditReservation.cs`: Formulário para adicionar/editar reservas.
│   - `FormAddEditReview.cs`: Formulário para adicionar/editar avaliações.
│   - `ClientList.cs`: Listagem de clientes.
│
├── Enums/
│   Definições de enums utilizados no sistema:
│   - `AccommodationType.cs`: Tipos de acomodações (ex.: vista jardim, vista piscina).
│   - `PaymentStatus.cs`: Status de pagamentos (ex.: pendente, concluído).
│   - `ReviewRating.cs`: Classificações de avaliações (1 a 5 estrelas).
│
├── Data/
│   Arquivos JSON para armazenamento de dados:
│   - `clients.json`
│   - `accommodations.json`
│   - `reservations.json`
│   - `reviews.json`
│   - `payments.json`
│
├── Program.cs
├── README.md
└── .gitignore

*Technology Stack*

- Language: C#
- Framework: .NET Framework (Windows Forms)
- Data Storage: JSON files for lightweight and portable data persistence.

*Usage Instructions*

- Adding a Client

Navigate to the Clients section in the main dashboard.

Click Add Client and fill out the required details.
Click Save to confirm.
Making a Reservation
Go to the Reservations section.
Select a client and accommodation.
Specify the check-in and check-out dates.
Confirm the reservation to calculate the total price and save.

- Recording a Payment
- Open the Payments section.
- Choose a reservation and input payment details.
- Set the payment method and status.
- Save the payment record.

*Future Enhancements*

- Modernized UI: Update the Windows Forms design for a more user-friendly interface.
- Database Integration: Migrate from JSON to a relational database (e.g., SQL Server) for improved scalability.
- Authentication: Add user login functionality to secure access.
- Advanced Reporting: Include dashboards for detailed analytics and insights.

Autor:
Danilo Castro
https://github.com/DaniloTeixeiraCastro/TP_POO_25457
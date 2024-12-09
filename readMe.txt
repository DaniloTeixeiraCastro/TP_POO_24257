Sobre o Projeto
O Tourist Accommodation System é uma aplicação desenvolvida em C# (Windows Forms) que oferece funcionalidades completas para a gestão de um sistema de alojamento turístico. Este sistema permite gerir clientes, reservas, acomodações, pagamentos e avaliações, garantindo uma experiência intuitiva e eficiente tanto para o administrador quanto para os utilizadores.

Funcionalidades Principais

Clientes
Adicionar, editar e remover clientes.
Listagem de clientes com detalhes como nome, email, telefone, data de nascimento e NIF.
Validação automática de dados:
Verificação de idade mínima (18 anos).
Validação de emails e campos obrigatórios.
Acomodações
Adicionar, editar e remover acomodações.
Gestão do estado das acomodações (disponível/ocupado).
Filtragem de acomodações por tipo, estado e preço.
Reservas
Adicionar, editar e cancelar reservas.
Seleção automática de acomodações disponíveis com base em datas de check-in e check-out.
Cálculo automático do preço total com base nas noites e preço por noite.
Pagamentos
Registo de pagamentos com diferentes métodos:
Dinheiro, cartão de crédito/débito, transferência bancária.
Gestão do estado de pagamentos (pendente, concluído, reembolsado).
Avaliações
Adicionar avaliações com possibilidade de anonimato.
Atribuição de classificações de 1 a 5 estrelas.
Listagem de avaliações com detalhes como comentário, cliente (se aplicável) e classificação.


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
│
├── Program.cs
├── README.md
└── .gitignore

Como Executar
Pré-requisitos
IDE: Visual Studio (versão 2022 ou superior recomendada).
.NET Framework (compatível com projetos Windows Forms).
Passos
Clone o repositório do GitHub:
bash
Copiar código
git clone https://github.com/seu-usuario/tourist-accommodation-system.git
Abra o projeto no Visual Studio.
Compile o projeto para garantir que todas as dependências estão resolvidas.
Execute a aplicação (Ctrl + F5).
Armazenamento de Dados
Os dados são persistidos em arquivos JSON localizados na pasta Data/. Esses arquivos contêm informações sobre clientes, reservas, acomodações e avaliações, permitindo que o sistema mantenha as informações entre sessões.

Autor:
Danilo Castro
https://github.com/DaniloTeixeiraCastro/TP_POO_25457
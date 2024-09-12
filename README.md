# Food Service Application

This is a web-based application for connecting clients with chefs, allowing users to hire chefs for custom meals, catering events, and more. The platform enables personalized food experiences by providing a direct channel between chefs and customers.



# Features

- Chef Profiles: Chefs can create portfolios showcasing their specialties, manage orders, and update availability.

- Client Services: Clients can browse chefs, view their profiles, place and manage orders, and leave feedback.

- Order Management: Orders can be created, updated, and canceled by clients, with real-time tracking of delivery status.

- Delivery Tracking: Includes a delivery system for tracking and managing order statuses.

- Feedback & Reports: Clients can leave feedback, and kitchen inspections ensure that chefs maintain quality standards.

  # Components

- User: Base class that is inherited by both chefs and clients.
  
- Chef: Can manage orders, update availability, and create portfolios.
  
- Client: Can browse chefs, place orders, make payments, and leave feedback.
  
- Order System: Handles placing, updating, and canceling orders, along with tracking delivery.
  
- Delivery: Manages order delivery statuses and handles price acceptance/rejection.
  
- Kitchen Inspection: Ensures chefs' kitchens meet quality standards, with the ability to generate reports.
  
- Payments: Facilitates client payments for orders.

   # Class Diagram
The class diagram includes key entities: User, Chef, Client, Delivery, Order, Payment, Kitchen Inspection, and Feedback, with their relationships and methods.


# Installation & Setup

1. Clone the repository: git clone <repository_url>

2.Install dependencies:  npm install / pip install -r requirements.txt

3.Set up the database (migration instructions here)

4. Run the application: npm start / dotnet run
  



 


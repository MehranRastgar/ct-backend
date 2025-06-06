# ct-backend

git subtree add --prefix=microservices/ctcom.identity-service https://github.com/ArsacidTechnologies/ctcom.identity-service master --squash

git subtree add --prefix=microservices/ctcom.product-service https://github.com/ArsacidTechnologies/ctcom.product-service master --squash


git subtree pull--prefix=microservices/ctcom.product-service https://github.com/ArsacidTechnologies/ctcom.product-service master --squash

## Theory of App

### **Seller Service** :

**Responsibility** : Manages individual seller data, such as seller profiles, settings, and preferences. This service stores all seller-related information like seller ID, name, payment details, etc.

**Operations** :

- Seller registration
- Seller updates (e.g., changing payment settings)
- Seller-specific configurations

### **Product Catalog Service** :

**Responsibility** : Each seller may manage their own product catalog, so this service deals with the creation, update, and deletion of products for individual sellers.

**Operations** :

- Product creation, updates, and deletions
- Assigning products to specific sellers
- Product categorization

**Event Examples** :

- `ProductCreatedEvent`
- `ProductUpdatedEvent`
- `ProductDeletedEvent`

### **Order Service** :

**Responsibility** : Manages the orders placed by customers. It should track orders from multiple sellers, route them correctly, and handle payments and fulfillment.

**Operations** :

- Order creation (split orders if multiple sellers are involved)
- Order status updates (e.g., shipping status)
- Order fulfillment and delivery

**Event Examples** :

- `OrderPlacedEvent`
- `OrderShippedEvent`
- `OrderDeliveredEvent`

### **Inventory Service** :

**Responsibility** : Tracks the stock levels for each seller's products. Ensures that inventory is accurately updated when an order is placed, canceled, or fulfilled.

**Operations** :

- Stock level management (per seller)
- Notifications on stock depletion or replenishment

**Event Examples** :

- `InventoryUpdatedEvent`
- `LowStockAlertEvent`

### **Notification Service** :

**Responsibility** : Sends out notifications to sellers and customers. For example, notifying sellers of new orders, stock updates, or customer inquiries.

**Operations** :

- Notifications via email, SMS, or in-app messages

**Event Examples** :

- `SellerNotificationEvent`
- `CustomerNotificationEvent`

### **Payment Service** :

**Responsibility** : Manages payments from customers and revenue distribution to sellers. This service would need to handle payment gateways, seller payouts, and refunds.

**Operations** :

- Payment processing (for orders involving multiple sellers)
- Revenue split among sellers
- Handling payment-related disputes

**Event Examples** :

- `PaymentProcessedEvent`
- `RefundIssuedEvent`

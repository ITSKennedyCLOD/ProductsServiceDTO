# Product Microservice - DTO

## Events Shared Created
#### NewProductEvent
All'inserimento di un nuovo prodotto 
Payload:
	Id
	Nome
	Descrizione
	Aliquota
	Marca
	Prezzo

#### UpdateProductEvent 
All'aggiornamento di un prodotto 
Payload:
	Id
	Nome
	Descrizione
	Marca
	Prezzo

#### DeleteProductEvent  
Alla cancellazione di un prodotto 
Payload:
	Id


## Events Shared Used

#### NewOrderEvent
Quando si crea un nuovo ordine
Payload:
	Id
	IdCliente
	TotalPrice
	DiscountAmount
	DiscountedPrice
	Products 

#### UpdatedOrderEvent
Quando si modifica un ordine
Payload:
	Id
	IdCliente
	TotalPrice
	DiscountAmount
	DiscountedPrice
	Products

#### DeletedOrderEvent
Quando si elimina un ordine
Payload:
	Id
	
#### CreateClientEvent
Evento di creazione Cliente
Payload:
	Id
	Name
	Surname
	Email
	Piva
	Businessname
	CF
	Address
	Year

#### UpdateClientEvent
Evento di modifica Cliente
Payload:
	Id
	Name
	Surname
	Email
	Piva
	Businessname
	CF
	Address
	Year
	
#### DeleteClientEvent
Evento di cancellazione Cliente
Payload:
	Id

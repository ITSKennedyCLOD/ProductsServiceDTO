# Microservizio Prodotti - DTO

	NewProductEvent  --> All'inserimento di un nuovo prodotto 
							Payload:
									Id
									Nome
									Descrizione
									Aliquota
									Marca
									Prezzo

	UpdateProductEvent  --> All'aggiornamento di un prodotto 
							Payload:
									Id
									Nome
									Descrizione
									Marca
									Prezzo

	DeleteProductEvent  --> Alla cancellazione di un prodotto 
							Payload:
									Id
									

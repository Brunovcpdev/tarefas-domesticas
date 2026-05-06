use Corporativo
go
CREATE TABLE Tarefas
(
	IdTarefa INT NOT NULL,
	NomeTarefa VARCHAR(30),
	Descricao VARCHAR(400),
	DataTarefa datetime,
	Prioridade INT,
	Responsavel VARCHAR(20)
)
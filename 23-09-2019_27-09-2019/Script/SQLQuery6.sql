UPDATE Livros -- PLAVRA reservada que atualiza as informações
SET Ativo = 0-- Nossa tabela que sera  alteraso nformções
WHERE Id =-- set inicializa a primeira alteração em nosso sql
(SELECT ID  FROM Livros ORDER BY id DESC-- Expressãoque vai ser açterada 
OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY)-- palavra que inicializa a s condções para relizar esta alteração

-- 1. Inserir perfil 'Administrador' se ainda não existir

INSERT INTO perfis (nome_perfil, descricao)

SELECT 'Administrador', 'Perfil com acesso completo ao sistema'

WHERE NOT EXISTS (

    SELECT 1 FROM perfis WHERE nome_perfil = 'Administrador'

);
 
-- 2. Inserir o usuário 'Administrador' com senha criptografada (SHA-256 para 'admin123')

INSERT INTO usuarios (nome, email, senha_hash, ativo)

VALUES ('Administrador do Sistema', 'admin@senac.com.br', sha2('admin123', 256), TRUE);
 
-- 3. Associar o usuário ao perfil de 'Administrador'

INSERT INTO usuarios_perfis (id_usuario, id_perfil)

SELECT 

    u.id_usuario,

    p.id_perfil

FROM 

    usuarios u,

    perfis p

WHERE 

    u.email = 'admin@senac.com.br'

    AND p.nome_perfil = 'Administrador';
 
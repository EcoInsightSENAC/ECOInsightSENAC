-- 1. Inserir perfil 'Administrador' se ainda não existir
INSERT INTO perfis (nome_perfil, descricao)
SELECT 'Administrador', 'Perfil com acesso completo ao sistema'
WHERE NOT EXISTS (
    SELECT 1 FROM perfis WHERE nome_perfil = 'Administrador'
);

-- 2. Inserir o usuário 'Administrador' com senha criptografada (SHA-256 para 'admin123')
-- Certifique-se de que a coluna 'telefone' exista na tabela 'usuarios', ou adicione ela primeiro!
-- ALTER TABLE usuarios ADD COLUMN telefone VARCHAR(20); -- Caso o campo 'telefone' ainda não exista!

INSERT INTO usuarios (nome, email, senha_hash, telefone, ativo)
VALUES ('Administrador do Sistema', 'admin@senac.com.br', sha2('admin123', 256), '11999999999', TRUE);

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

-- 4. Criar perfil 'Aluno' sem associar a nenhum usuário
INSERT INTO perfis (nome_perfil, descricao)
SELECT 'Aluno', 'Perfil para alunos, com acesso a informações gerais sobre reciclagem'
WHERE NOT EXISTS (
    SELECT 1 FROM perfis WHERE nome_perfil = 'Aluno'
);

-- 5. Criar perfil 'Professor' sem associar a nenhum usuário
INSERT INTO perfis (nome_perfil, descricao)
SELECT 'Professor', 'Perfil para professores, com permissões para gerenciar conteúdo educacional sobre reciclagem'
WHERE NOT EXISTS (
    SELECT 1 FROM perfis WHERE nome_perfil = 'Professor'
);

-- 6. Criar perfil 'Funcionário' sem associar a nenhum usuário
INSERT INTO perfis (nome_perfil, descricao)
SELECT 'Funcionário', 'Perfil para funcionários que registram coletas e gerenciam o descarte de materiais recicláveis'
WHERE NOT EXISTS (
    SELECT 1 FROM perfis WHERE nome_perfil = 'Funcionário'
);

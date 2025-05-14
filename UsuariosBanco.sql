-- 7. Inserir usuário 'Aluno Padrão' se ainda não existir
INSERT INTO usuarios (nome, email, senha_hash, telefone, ativo)
SELECT 'Aluno Padrão', 'aluno@senac.com.br', sha2('senha123', 256), '11988887777', TRUE
WHERE NOT EXISTS (
    SELECT 1 FROM usuarios WHERE email = 'aluno@senac.com.br'
);

-- Associar o usuário ao perfil 'Aluno'
INSERT INTO usuarios_perfis (id_usuario, id_perfil)
SELECT 
    u.id_usuario,
    p.id_perfil
FROM 
    usuarios u,
    perfis p
WHERE 
    u.email = 'aluno@senac.com.br'
    AND p.nome_perfil = 'Aluno';

-- 8. Inserir usuário 'Professor Padrão' se ainda não existir
INSERT INTO usuarios (nome, email, senha_hash, telefone, ativo)
SELECT 'Professor Padrão', 'professor@senac.com.br', sha2('senha123', 256), '11977776666', TRUE
WHERE NOT EXISTS (
    SELECT 1 FROM usuarios WHERE email = 'professor@senac.com.br'
);

-- Associar o usuário ao perfil 'Professor'
INSERT INTO usuarios_perfis (id_usuario, id_perfil)
SELECT 
    u.id_usuario,
    p.id_perfil
FROM 
    usuarios u,
    perfis p
WHERE 
    u.email = 'professor@senac.com.br'
    AND p.nome_perfil = 'Professor';

-- 9. Inserir usuário 'Funcionário Padrão' se ainda não existir
INSERT INTO usuarios (nome, email, senha_hash, telefone, ativo)
SELECT 'Funcionário Padrão', 'funcionario@senac.com.br', sha2('senha123', 256), '11966665555', TRUE
WHERE NOT EXISTS (
    SELECT 1 FROM usuarios WHERE email = 'funcionario@senac.com.br'
);

-- Associar o usuário ao perfil 'Funcionário'
INSERT INTO usuarios_perfis (id_usuario, id_perfil)
SELECT 
    u.id_usuario,
    p.id_perfil
FROM 
    usuarios u,
    perfis p
WHERE 
    u.email = 'funcionario@senac.com.br'
    AND p.nome_perfil = 'Funcionário';

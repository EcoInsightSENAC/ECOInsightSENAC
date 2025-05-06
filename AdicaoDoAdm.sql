-- 1. Inserir perfil se ainda não existir
INSERT INTO perfis (nome_perfil, descricao)
SELECT 'Administrador', 'Perfil com acesso completo ao sistema'
WHERE NOT EXISTS (
    SELECT 1 FROM perfis WHERE nome_perfil = 'Administrador'
);

-- 2. Inserir o usuário com senha hash (exemplo com SHA-256 para 'admin123')
INSERT INTO usuarios (nome, email, senha_hash, ativo)
VALUES ('Administrador do Sistema', 'admin@senac.com.br', 
        'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f', 
        TRUE);

-- 3. Associar o usuário ao perfil de Administrador
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
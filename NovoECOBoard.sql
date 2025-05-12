DROP DATABASE ecoboard;

CREATE DATABASE IF NOT EXISTS ECOBoard;
USE ECOBoard;
 
-- Tabela de usuários (contém dados básicos)
CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    telefone VARCHAR(20) NOT NULL,  
    senha_hash VARCHAR(255) NOT NULL,
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
    ativo BOOLEAN DEFAULT TRUE
);
 
-- Tabela de perfis de usuários
CREATE TABLE perfis (
    id_perfil INT PRIMARY KEY AUTO_INCREMENT,
    nome_perfil VARCHAR(50) NOT NULL,
    descricao TEXT
);
 
-- Tabela de relação entre usuários e perfis
CREATE TABLE usuarios_perfis (
    id_usuario INT,
    id_perfil INT,
    PRIMARY KEY (id_usuario, id_perfil),
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_perfil) REFERENCES perfis(id_perfil) ON DELETE CASCADE
);
 
-- Tabela de funcionários (dados adicionais como turno)
CREATE TABLE funcionarios (
    id_funcionario INT PRIMARY KEY AUTO_INCREMENT,
    id_usuario INT UNIQUE,
    turno VARCHAR(50),  -- Ex: "Manhã", "Tarde", "Noite"
    data_contratacao DATE,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario) ON DELETE CASCADE
);
 
-- Funções que um funcionário pode desempenhar
CREATE TABLE funcoes_limpeza (
    id_funcao INT PRIMARY KEY AUTO_INCREMENT,
    nome_funcao VARCHAR(100) NOT NULL,
    descricao TEXT
);
 
-- Relação muitos-para-muitos entre funcionários e funções
CREATE TABLE funcionarios_funcoes (
    id_funcionario INT,
    id_funcao INT,
    PRIMARY KEY (id_funcionario, id_funcao),
    FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id_funcionario) ON DELETE CASCADE,
    FOREIGN KEY (id_funcao) REFERENCES funcoes_limpeza(id_funcao) ON DELETE CASCADE
);
 
-- Materiais recicláveis
CREATE TABLE materiais_reciclaveis (
    id_material INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    descricao TEXT,
    taxa_reciclabilidade DECIMAL(5,2)
);
 
-- Registros de coletas de materiais
CREATE TABLE registro_coletas (
    id_coleta INT PRIMARY KEY AUTO_INCREMENT,
    id_funcionario INT,
    id_material INT,
    quantidade DECIMAL(10,2) NOT NULL,
    data_coleta DATETIME DEFAULT CURRENT_TIMESTAMP,
    local_coleta VARCHAR(100),
    FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id_funcionario) ON DELETE SET NULL,
    FOREIGN KEY (id_material) REFERENCES materiais_reciclaveis(id_material) ON DELETE SET NULL
);
 
-- Pontuação dos funcionários com base na reciclagem
CREATE TABLE pontuacao_reciclagem (
    id_pontuacao INT PRIMARY KEY AUTO_INCREMENT,
    id_funcionario INT,
    pontos INT DEFAULT 0,
    data_atualizacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id_funcionario) ON DELETE CASCADE
);
 
-- Tabela de telas (interface/funcionalidades do sistema)
CREATE TABLE telas (
    id_telas INT PRIMARY KEY AUTO_INCREMENT,
    nome_telas VARCHAR(100) NOT NULL,
    descricao TEXT
);
 
-- Permissões por perfil e tela
CREATE TABLE permissoes (
    id_permissoes INT PRIMARY KEY AUTO_INCREMENT,
    id_perfil INT,
    id_telas INT,
    pode_visualizar BOOLEAN DEFAULT FALSE,
    pode_editar BOOLEAN DEFAULT FALSE,
    pode_excluir BOOLEAN DEFAULT FALSE,
    pode_inserir BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (id_perfil) REFERENCES perfis(id_perfil) ON DELETE CASCADE,
    FOREIGN KEY (id_telas) REFERENCES telas(id_telas) ON DELETE CASCADE
);
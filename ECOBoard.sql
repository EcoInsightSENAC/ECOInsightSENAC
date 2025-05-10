create database  ECOBoard;

use ECOBoard;

CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    senha_hash VARCHAR(255) NOT NULL,  -- Senha criptografada
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
    ativo BOOLEAN DEFAULT TRUE
);

CREATE TABLE perfis (
    id_perfil INT PRIMARY KEY AUTO_INCREMENT,
    nome_perfil VARCHAR(50) NOT NULL,  -- Ex: "Administrador", "Funcionário Reciclagem", "Supervisor"
    descricao TEXT
);

CREATE TABLE usuarios_perfis (
    id_usuario INT,
    id_perfil INT,
    PRIMARY KEY (id_usuario, id_perfil),
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
    FOREIGN KEY (id_perfil) REFERENCES perfis(id_perfil)
);

-- Tabelas especificas para funcionários

CREATE TABLE funcionarios (
    id_funcionario INT PRIMARY KEY,
    id_usuario INT UNIQUE,
    data_contratacao DATE,
    turno VARCHAR(50),  -- Ex: "Manhã", "Tarde", "Noite"
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);

CREATE TABLE funcoes_limpeza (
    id_funcao INT PRIMARY KEY AUTO_INCREMENT,
    nome_funcao VARCHAR(100) NOT NULL,  -- Ex: "Separador de Resíduos", "Coletor de Recicláveis"
    descricao TEXT
);

CREATE TABLE funcionarios_funcoes (
    id_funcionario INT,
    id_funcao INT,
    PRIMARY KEY (id_funcionario, id_funcao),
    FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id_funcionario),
    FOREIGN KEY (id_funcao) REFERENCES funcoes_limpeza(id_funcao)
);

-- Tabelas para gestão de reciclagem 

CREATE TABLE materiais_reciclaveis (
    id_material INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,  -- Ex: "Papel", "Plástico PET", "Alumínio"
    descricao TEXT,
    taxa_reciclabilidade DECIMAL(5,2)  -- % de aproveitamento
);

CREATE TABLE registro_coletas (
    id_coleta INT PRIMARY KEY AUTO_INCREMENT,
    id_funcionario INT,
    id_material INT,
    quantidade DECIMAL(10,2) NOT NULL,  -- Peso em kg
    data_coleta DATETIME DEFAULT CURRENT_TIMESTAMP,
    local_coleta VARCHAR(100),  -- Ex: "Setor Administrativo", "Refeitório"
    FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id_funcionario),
    FOREIGN KEY (id_material) REFERENCES materiais_reciclaveis(id_material)
);

CREATE TABLE pontuacao_reciclagem (
    id_pontuacao INT PRIMARY KEY AUTO_INCREMENT,
    id_funcionario INT,
    pontos INT DEFAULT 0,
    data_atualizacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id_funcionario)
); 
-- Criando a tabela de telas
CREATE TABLE telas (
    id_telas INT PRIMARY KEY AUTO_INCREMENT,
    nome_telas VARCHAR(100) NOT NULL,
    descricao TEXT
);

-- Criando a tabela de permissoes

CREATE TABLE permissoes (
    id_permissoes INT PRIMARY KEY AUTO_INCREMENT,
    id_perfil INT,
    id_telas INT,
    pode_visualizar BOOLEAN DEFAULT FALSE,
    pode_editar BOOLEAN DEFAULT FALSE,
    pode_excluir BOOLEAN DEFAULT FALSE,
    pode_inserir BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (id_perfil) REFERENCES perfis(id_perfil),
    FOREIGN KEY (id_telas) REFERENCES telas(id_telas)
);
-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 24-Fev-2018 às 14:24
-- Versão do servidor: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `oficina`
--
CREATE DATABASE IF NOT EXISTS `oficina` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `oficina`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `data_nascimento` date NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `cpf` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id`, `nome`, `data_nascimento`, `telefone`, `cpf`) VALUES
(1, 'Filipe Tório', '1987-05-22', '123456789', '07012345687'),
(2, 'Thiago Hoffman', '1978-03-02', '55874585', '04585236548'),
(3, 'Carla Cardoso', '1983-03-07', '55478525', '0458525696'),
(4, 'Henrique', '1988-10-28', '225454585', '07085825632'),
(5, 'Fernanda', '1986-05-02', '33547852', '04052856525'),
(6, 'Ana', '1996-02-03', '33525252', '02052556545'),
(7, 'cliente', '2001-01-01', '333', '123');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `data_nascimento` date NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `cpf` char(11) NOT NULL,
  `endereco` varchar(60) not null,
`numero` Varchar(60) not null,
`complemento` Varchar(20) not null,
`bairro` Varchar(60) not null,
`cep` Varchar(10) not null,
 `cidade` Varchar(60) not null,
 `uf` Varchar(2) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`id`, `nome`, `data_nascimento`, `telefone`, `cpf`, `endereco`,`numero`,`complemento`,`bairro`,`cep`,`cidade`,`uf` ) VALUES
(1, 'José', '1970-05-05', '33256585', '14528565478',null,null,null,null,null,null,null),
(2, 'Marcelo', '1978-07-07', '33528545', '01256895874',null,null,null,null,null,null,null),
(3, 'Maria', '1965-03-03', '332564585', '01254785265',null,null,null,null,null,null,null),
(4, 'Gabriel', '2001-01-01', '333', '123',null,null,null,null,null,null,null);

-- --------------------------------------------------------

--
-- Estrutura da tabela `marca`
--

CREATE TABLE `marca` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `marca`
--

INSERT INTO `marca` (`id`, `nome`) VALUES
(1, 'FIAT'),
(2, 'VOLKSWAGEM'),
(3, 'CHEVROLET'),
(4, 'FORD'),
(5, 'HONDA'),
(6, 'TOYOTA'),
(7, 'NISSAN'),
(8, 'BMW');

-- --------------------------------------------------------

--
-- Estrutura da tabela `modelo`
--

CREATE TABLE `modelo` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `id_marca` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `modelo`
--

INSERT INTO `modelo` (`id`, `nome`, `id_marca`) VALUES
(1, 'UNO', 1),
(2, 'PALIO', 1),
(3, 'SIENA', 1),
(4, 'STILO', 1),
(5, 'VOYAGE', 2),
(6, 'GOL', 2),
(7, 'SPACEFOX', 2),
(8, 'FOX', 2),
(9, 'OPALA', 3),
(10, 'VECTRA', 3),
(11, 'OMEGA', 3),
(12, 'PRISMA', 3),
(13, 'S10', 3),
(14, 'BLAZER', 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ordem_servico`
--

CREATE TABLE `ordem_servico` (
  `id` int(11) NOT NULL,
  `data_os` date NOT NULL,
  `id_veiculo` int(11) NOT NULL,
  `descricao_defeito` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `ordem_servico`
--

INSERT INTO `ordem_servico` (`id`, `data_os`, `id_veiculo`, `descricao_defeito`) VALUES
(1, '2015-11-11', 1, 'CONSUMO EXCESSIVO DE COMBUSTÍVEL'),
(2, '2015-11-01', 2, 'TROCA DE ÓLEO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `os_produto`
--

CREATE TABLE `os_produto` (
  `id` int(11) NOT NULL,
  `id_os` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `qtde` int(11) NOT NULL,
  `preco` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `os_produto`
--

INSERT INTO `os_produto` (`id`, `id_os`, `id_produto`, `qtde`, `preco`) VALUES
(1, 2, 1, 1, 50),
(2, 2, 2, 1, 80);

-- --------------------------------------------------------

--
-- Estrutura da tabela `os_servico`
--

CREATE TABLE `os_servico` (
  `id` int(11) NOT NULL,
  `id_os` int(11) NOT NULL,
  `id_servico` int(11) NOT NULL,
  `tempo_realizado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `os_servico`
--

INSERT INTO `os_servico` (`id`, `id_os`, `id_servico`, `tempo_realizado`) VALUES
(1, 1, 4, 60),
(2, 2, 2, 80);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `preco` double NOT NULL,
  `qtde_estoque` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id`, `nome`, `preco`, `qtde_estoque`) VALUES
(1, 'FILTRO DE ÓELO', 45, 100),
(2, 'OLEO MOTOR 25W60', 18, 50),
(3, 'FILTRO DE AR', 25, 60),
(4, 'CORREIA DENTADA', 78, 20),
(5, 'produto', 100, 50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

CREATE TABLE `servico` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `preco` double NOT NULL,
  `tempo_estimado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `servico`
--

INSERT INTO `servico` (`id`, `nome`, `preco`, `tempo_estimado`) VALUES
(1, 'LIMPEZA GERAL', 120, 180),
(2, 'TROCA DE OLEO', 50, 30),
(3, 'RETÍFICA COMPLETA', 800, 2000),
(4, 'REGULAGEM CARBURADOR', 150, 120),
(5, 'REVISÃO GERAL', 250, 240),
(6, 'REVISÃO FREIOS', 80, 60),
(7, 'REVISÃO INJEÇÃO ELETRÔNICA', 120, 180),
(8, 'servico', 100, 50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculo`
--

CREATE TABLE `veiculo` (
  `id` int(11) NOT NULL,
  `placa` char(8) NOT NULL,
  `ano` char(4) NOT NULL,
  `cor` varchar(20) NOT NULL,
  `id_dono` int(11) NOT NULL,
  `id_modelo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `veiculo`
--

INSERT INTO `veiculo` (`id`, `placa`, `ano`, `cor`, `id_dono`, `id_modelo`) VALUES
(1, 'ABC4545', '1983', 'BEGE', 1, 9),
(2, 'HLX4578', '2005', 'AZUL', 2, 1),
(3, 'BMQ4585', '2010', 'PRATA', 3, 2),
(4, 'AMG7858', '2014', 'PRETO', 4, 3),
(5, 'GHK7885', '2012', 'VERMELHO', 5, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `modelo`
--
ALTER TABLE `modelo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_marca` (`id_marca`);

--
-- Indexes for table `ordem_servico`
--
ALTER TABLE `ordem_servico`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_veiculo` (`id_veiculo`);

--
-- Indexes for table `os_produto`
--
ALTER TABLE `os_produto`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_os` (`id_os`),
  ADD KEY `id_produto` (`id_produto`);

--
-- Indexes for table `os_servico`
--
ALTER TABLE `os_servico`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_os` (`id_os`),
  ADD KEY `id_servico` (`id_servico`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `veiculo`
--
ALTER TABLE `veiculo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_dono` (`id_dono`),
  ADD KEY `id_modelo` (`id_modelo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `marca`
--
ALTER TABLE `marca`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `modelo`
--
ALTER TABLE `modelo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `ordem_servico`
--
ALTER TABLE `ordem_servico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `os_produto`
--
ALTER TABLE `os_produto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `os_servico`
--
ALTER TABLE `os_servico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `servico`
--
ALTER TABLE `servico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `veiculo`
--
ALTER TABLE `veiculo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `modelo`
--
ALTER TABLE `modelo`
  ADD CONSTRAINT `modelo_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id`);

--
-- Limitadores para a tabela `ordem_servico`
--
ALTER TABLE `ordem_servico`
  ADD CONSTRAINT `ordem_servico_ibfk_1` FOREIGN KEY (`id_veiculo`) REFERENCES `veiculo` (`id`);

--
-- Limitadores para a tabela `os_produto`
--
ALTER TABLE `os_produto`
  ADD CONSTRAINT `os_produto_ibfk_1` FOREIGN KEY (`id_os`) REFERENCES `ordem_servico` (`id`),
  ADD CONSTRAINT `os_produto_ibfk_2` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id`);

--
-- Limitadores para a tabela `os_servico`
--
ALTER TABLE `os_servico`
  ADD CONSTRAINT `os_servico_ibfk_1` FOREIGN KEY (`id_os`) REFERENCES `ordem_servico` (`id`),
  ADD CONSTRAINT `os_servico_ibfk_2` FOREIGN KEY (`id_servico`) REFERENCES `servico` (`id`);

--
-- Limitadores para a tabela `veiculo`
--
ALTER TABLE `veiculo`
  ADD CONSTRAINT `veiculo_ibfk_1` FOREIGN KEY (`id_dono`) REFERENCES `cliente` (`id`),
  ADD CONSTRAINT `veiculo_ibfk_2` FOREIGN KEY (`id_modelo`) REFERENCES `modelo` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
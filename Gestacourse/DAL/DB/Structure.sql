drop table if exists course;
drop table if exists participant;
drop table if exists resultat;

create table course (
    id_course integer not null primary key auto_increment,
    distance integer not null
);

create table participant (
	id_participant integer not null primary key auto_increment,
	num_dossard integer not null,
	nom_coureur varchar(200) not null,
	prenom_coureur varchar(200) not null,
	age_coureur integer null,
	sexe_coureur varchar(1) not null,
	date_naissance_coureur datetime not null,
	mail_coureur varchar(50) not null,
	nb_ffa_coureur varchar(50)
);

create table resultat (
	id_resultat integer not null primary key auto_increment,
	classement integer not null,
	vitesse_moyenne double not null,
	allure_moyenne double not null,
	temps date not null,
	constraint coureur foreign key(id_participant) references participant(id_participant),
	id_course integer,
	constraint course foreign key(id_course) references course(id_course)
);

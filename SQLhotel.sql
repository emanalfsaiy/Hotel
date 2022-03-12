Select*from Employ

Select*from tel

Select*from Coustomer





insert into[dbo].[Employ] (mployname,validity,pass,idhotel )
VALUES ('Ahmed','„”ƒÊ· ·ÕÃ“ ', '123','1')

insert into[dbo].[tel] (namehotel )
VALUES ('star5');

insert into[dbo].[Coustomer] (name_customer,phone_number,countre,proof_id )
VALUES ('fatma','092453768 ', 'Egypt','3') 

insert into[dbo].[Proo] (type_proof,proof_number )
VALUES ( 'ÃÊ«“«·”›— ','1228446001')

insert into[dbo].[Reservation] (id_customer,idemploy,Date_reservation,Date_departure,room_number,num_room )
VALUES ('2','9','1-3-2022','1-4-2022', '100','1') 

update Coustomer
set name_customer='safa'
where id_customer=1

select Coustomer.name_customer,Coustomer.phone_number,Coustomer.countre,
Reservation.Date_reservation,Reservation.Date_departure,Reservation.room_number,Reservation.num_room   
 from Coustomer join Reservation on Coustomer.id_customer=Reservation.id_customer 
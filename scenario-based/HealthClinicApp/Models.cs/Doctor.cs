class Doctor
{
    /*
create table Doctor(doctorId int identity(1,1) primary key,
                    doctorName varchar(50) not null,
					specialtyId int,
					contact varchar(50),
					consultationFee decimal(10,2),
					is_active bit default 1,
					constraint fk_specialty
					    foreign key (specialtyId)
						references Specialties(specialtyId)
					);
*/

    public int doctorId { get; set; }
    public string doctorName{ get; set; }
    public int specialtyId { get; set; }
    public string contact { get; set; }
    public double consultationFee { get; set; }
}
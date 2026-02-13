using System;

public interface IAdminService
{
    public Task AddDoctorAsync(Doctor doctor);

    public Task UpdateSpecialityAsync(String contact, String updatedSpeciality);
}
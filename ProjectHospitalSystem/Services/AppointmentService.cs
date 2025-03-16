using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ProjectHospitalSystem.Services
{
    public class AppointmentService
    {
        private readonly HospitalSystemContext _context;
        public AppointmentService(HospitalSystemContext context)
        {
            _context = context;
        }

        public async Task AddAppointmentAsync(int doctorDetailsId, DateTime appointmentDateTime)
        {
            // Ensure the doctor has an available slot on the specified date
            var availableSlot = await _context.Doctor_Schedules
                .Where(ds => ds.DoctorDetailsId == doctorDetailsId && ds.ScheduleDay.Date == appointmentDateTime.Date)
                .FirstOrDefaultAsync();

            if (availableSlot == null)
            {
                throw new InvalidOperationException($"No available slot found for doctor with ID {doctorDetailsId} on {appointmentDateTime.ToShortDateString()}");
            }

            // Create the new appointment
            var newAppointment = new Appointment
            {
                AppointmentDateTime = appointmentDateTime,
                Status = AppointmentStatus.Upcoming,
                ReminderSent = false,
                DoctorDetailsId = doctorDetailsId
            };

            _context.Appointments.Add(newAppointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppointmentAsync(int appointmentId, DateTime appointmentDateTime)
        {
            var appointmentToUpdate = await _context.Appointments.FindAsync(appointmentId);

            if (appointmentToUpdate == null)
            {
                throw new InvalidOperationException("Appointment not found.");
            }

            appointmentToUpdate.AppointmentDateTime = appointmentDateTime;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int appointmentId)
        {
            var appointmentToDelete = await _context.Appointments.FindAsync(appointmentId);

            if (appointmentToDelete == null)
            {
                throw new InvalidOperationException("Appointment not found.");
            }

            _context.Appointments.Remove(appointmentToDelete);
            await _context.SaveChangesAsync();
        }
    }
}


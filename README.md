# HMO

## Project Description:

A system for managing appointments for the HMO. Through the system, you can book appointments with doctors and manage all queues at the station.

## Entities:

- Patient
- Doctor
- Turn

## Routes Mapping for Patients:

- **Retrieve a list of patients:**  
  `GET: https://maccabi4u.co.il/patients`

- **Retrieve a patient by ID:**  
  `GET: https://maccabi4u.co.il/patients/1`

- **Add a patient:**  
  `POST: https://maccabi4u.co.il/patients`

- **Update a patient:**  
  `PUT: https://maccabi4u.co.il/patients/1`

- **Update patient status:**  
  `PUT: https://maccabi4u.co.il/patients/1/status`

## Routes Mapping for Doctors:

- **Retrieve a list of doctors:**  
  `GET: https://maccabi4u.co.il/doctors`

- **Retrieve a doctor by ID:**  
  `GET: https://maccabi4u.co.il/doctors/1`

- **Add a doctor:**  
  `POST: https://maccabi4u.co.il/doctors`

- **Update a doctor:**  
  `PUT: https://maccabi4u.co.il/doctors/1`

- **Update doctor status:**  
  `PUT: https://maccabi4u.co.il/doctors/1/status`

## Routes Mapping for Queues:

- **Retrieve a list of queues:**  
  `GET: https://maccabi4u.co.il/queues`

- **Retrieve a queue by ID:**  
  `GET: https://maccabi4u.co.il/queues/1`

- **Add a queue:**  
  `POST: https://maccabi4u.co.il/queues`

- **Update a queue:**  
  `PUT: https://maccabi4u.co.il/queues/1`

- **Delete a queue:**  
  `DELETE: https://maccabi4u.co.il/queues/1`

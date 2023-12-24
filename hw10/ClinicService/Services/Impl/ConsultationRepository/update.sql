UPDATE consultations
SET ClientId=@ClientId, PetId=@PetId, ConsultationDate=@ConsultationDate, Description=@Description
where ConsultationId=@ConsultationId
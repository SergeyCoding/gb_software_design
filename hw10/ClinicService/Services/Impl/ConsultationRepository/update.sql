UPDATE consultations
SET ClientId = @ClientId, PetId = @PetId, ConsultationDate = @ConsultationDate, Description = @Description
WHERE ConsultationId = @ConsultationId

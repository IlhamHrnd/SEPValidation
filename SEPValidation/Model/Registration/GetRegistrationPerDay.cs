using Newtonsoft.Json;

namespace SEPValidation.Model.Registration
{
    public class GetRegistrationPerDay
    {
        public class RegistrationRoot
        {
            [JsonProperty("registrationNo")]
            public string? registrationNo { get; set; }

            [JsonProperty("srRegistrationType")]
            public string? srRegistrationType { get; set; }

            [JsonProperty("paramedicID")]
            public string? paramedicID { get; set; }

            [JsonProperty("guarantorID")]
            public string? guarantorID { get; set; }

            [JsonProperty("patientID")]
            public string? patientID { get; set; }

            [JsonProperty("classID")]
            public string? classID { get; set; }

            [JsonProperty("registrationDate")]
            public DateTime? registrationDate { get; set; }

            [JsonProperty("registrationTime")]
            public string? registrationTime { get; set; }

            [JsonProperty("appointmentNo")]
            public string? appointmentNo { get; set; }

            [JsonProperty("ageInYear")]
            public int? ageInYear { get; set; }

            [JsonProperty("ageInMonth")]
            public int? ageInMonth { get; set; }

            [JsonProperty("ageInDay")]
            public int? ageInDay { get; set; }

            [JsonProperty("srShift")]
            public string? srShift { get; set; }

            [JsonProperty("srPatientInType")]
            public string? srPatientInType { get; set; }

            [JsonProperty("insuranceID")]
            public string? insuranceID { get; set; }

            [JsonProperty("srPatientCategory")]
            public string? srPatientCategory { get; set; }

            [JsonProperty("srerCaseType")]
            public string? srerCaseType { get; set; }

            [JsonProperty("srVisitReason")]
            public string? srVisitReason { get; set; }

            [JsonProperty("srBussinesMethod")]
            public string? srBussinesMethod { get; set; }

            [JsonProperty("plavonAmount")]
            public double? plavonAmount { get; set; }

            [JsonProperty("departmentID")]
            public string? departmentID { get; set; }

            [JsonProperty("serviceUnitID")]
            public string? serviceUnitID { get; set; }

            [JsonProperty("roomID")]
            public string? roomID { get; set; }

            [JsonProperty("bedID")]
            public string? bedID { get; set; }

            [JsonProperty("chargeClassID")]
            public string? chargeClassID { get; set; }

            [JsonProperty("coverageClassID")]
            public string? coverageClassID { get; set; }

            [JsonProperty("visitTypeID")]
            public string? visitTypeID { get; set; }

            [JsonProperty("referralID")]
            public string? referralID { get; set; }

            [JsonProperty("anamnesis")]
            public string? anamnesis { get; set; }

            [JsonProperty("complaint")]
            public string? complaint { get; set; }

            [JsonProperty("initialDiagnose")]
            public string? initialDiagnose { get; set; }

            [JsonProperty("medicationPlanning")]
            public string? medicationPlanning { get; set; }

            [JsonProperty("srTriage")]
            public string? srTriage { get; set; }

            [JsonProperty("isPrintingPatientCard")]
            public bool? isPrintingPatientCard { get; set; }

            [JsonProperty("dischargeDate")]
            public DateTime? dischargeDate { get; set; }

            [JsonProperty("dischargeTime")]
            public string? dischargeTime { get; set; }

            [JsonProperty("dischargeMedicalNotes")]
            public string? dischargeMedicalNotes { get; set; }

            [JsonProperty("dischargeNotes")]
            public string? dischargeNotes { get; set; }

            [JsonProperty("srDischargeCondition")]
            public string? srDischargeCondition { get; set; }

            [JsonProperty("srDischargeMethod")]
            public string? srDischargeMethod { get; set; }

            [JsonProperty("losInYear")]
            public int? losInYear { get; set; }

            [JsonProperty("losInMonth")]
            public int? losInMonth { get; set; }

            [JsonProperty("losInDay")]
            public int? losInDay { get; set; }

            [JsonProperty("dischargeOperatorID")]
            public string? dischargeOperatorID { get; set; }

            [JsonProperty("accountNo")]
            public string? accountNo { get; set; }

            [JsonProperty("transactionAmount")]
            public double? transactionAmount { get; set; }

            [JsonProperty("administrationAmount")]
            public double? administrationAmount { get; set; }

            [JsonProperty("roundingAmount")]
            public double? roundingAmount { get; set; }

            [JsonProperty("remainingAmount")]
            public double? remainingAmount { get; set; }

            [JsonProperty("isTransferedToInpatient")]
            public bool? isTransferedToInpatient { get; set; }

            [JsonProperty("isNewPatient")]
            public bool? isNewPatient { get; set; }

            [JsonProperty("isNewBornInfant")]
            public bool? isNewBornInfant { get; set; }

            [JsonProperty("isParturition")]
            public bool? isParturition { get; set; }

            [JsonProperty("isHoldTransactionEntry")]
            public bool? isHoldTransactionEntry { get; set; }

            [JsonProperty("isHasCorrection")]
            public bool? isHasCorrection { get; set; }

            [JsonProperty("isEMRValid")]
            public bool? isEMRValid { get; set; }

            [JsonProperty("isBackDate")]
            public bool? isBackDate { get; set; }

            [JsonProperty("actualVisitDate")]
            public DateTime? actualVisitDate { get; set; }

            [JsonProperty("isVoid")]
            public bool? isVoid { get; set; }

            [JsonProperty("srVoidReason")]
            public string? srVoidReason { get; set; }

            [JsonProperty("voidNotes")]
            public string? voidNotes { get; set; }

            [JsonProperty("voidDate")]
            public DateTime? voidDate { get; set; }

            [JsonProperty("voidByUserID")]
            public string? voidByUserID { get; set; }

            [JsonProperty("isClosed")]
            public bool? isClosed { get; set; }

            [JsonProperty("isEpisodeComplete")]
            public bool? isEpisodeComplete { get; set; }

            [JsonProperty("isClusterAssessment")]
            public bool? isClusterAssessment { get; set; }

            [JsonProperty("isConsul")]
            public bool? isConsul { get; set; }

            [JsonProperty("isFromDispensary")]
            public bool? isFromDispensary { get; set; }

            [JsonProperty("isNewVisit")]
            public bool? isNewVisit { get; set; }

            [JsonProperty("notes")]
            public string? notes { get; set; }

            [JsonProperty("lastCreateDateTime")]
            public DateTime? lastCreateDateTime { get; set; }

            [JsonProperty("lastCreateUserID")]
            public string? lastCreateUserID { get; set; }

            [JsonProperty("lastUpdateDateTime")]
            public DateTime? lastUpdateDateTime { get; set; }

            [JsonProperty("lastUpdateByUserID")]
            public string? lastUpdateByUserID { get; set; }

            [JsonProperty("isDirectPrescriptionReturn")]
            public bool? isDirectPrescriptionReturn { get; set; }

            [JsonProperty("registrationQue")]
            public int? registrationQue { get; set; }

            [JsonProperty("visiteRegistrationNo")]
            public string? visiteRegistrationNo { get; set; }

            [JsonProperty("isGenerateHL7")]
            public bool? isGenerateHL7 { get; set; }

            [JsonProperty("referralName")]
            public string? referralName { get; set; }

            [JsonProperty("isObservation")]
            public bool? isObservation { get; set; }

            [JsonProperty("causeOfAccident")]
            public string? causeOfAccident { get; set; }

            [JsonProperty("referTo")]
            public string? referTo { get; set; }

            [JsonProperty("isOldCase")]
            public bool? isOldCase { get; set; }

            [JsonProperty("isDHF")]
            public bool? isDHF { get; set; }

            [JsonProperty("isEKG")]
            public bool? isEKG { get; set; }

            [JsonProperty("emrDiagnoseID")]
            public string? emrDiagnoseID { get; set; }

            [JsonProperty("isGlobalPlafond")]
            public bool? isGlobalPlafond { get; set; }

            [JsonProperty("firstResponDate")]
            public DateTime? firstResponDate { get; set; }

            [JsonProperty("firstResponTime")]
            public string? firstResponTime { get; set; }

            [JsonProperty("physicianResponDate")]
            public DateTime? physicianResponDate { get; set; }

            [JsonProperty("physicianResponTime")]
            public string? physicianResponTime { get; set; }

            [JsonProperty("isRoomIn")]
            public bool? isRoomIn { get; set; }

            [JsonProperty("isLockVerifiedBilling")]
            public bool? isLockVerifiedBilling { get; set; }

            [JsonProperty("lockVerifiedBillingDateTime")]
            public DateTime? lockVerifiedBillingDateTime { get; set; }

            [JsonProperty("lockVerifiedBillingByUserID")]
            public string? lockVerifiedBillingByUserID { get; set; }

            [JsonProperty("procedureChargeClassID")]
            public string? procedureChargeClassID { get; set; }

            [JsonProperty("personID")]
            public int? personID { get; set; }

            [JsonProperty("employeeNumber")]
            public string? employeeNumber { get; set; }

            [JsonProperty("srEmployeeRelationship")]
            public string? srEmployeeRelationship { get; set; }

            [JsonProperty("guarantorCardNo")]
            public string? guarantorCardNo { get; set; }

            [JsonProperty("dischargePlanDate")]
            public DateTime? dischargePlanDate { get; set; }

            [JsonProperty("usertInsertDischargePlan")]
            public string? usertInsertDischargePlan { get; set; }

            [JsonProperty("isNonPatient")]
            public bool? isNonPatient { get; set; }

            [JsonProperty("reasonsForTreatmentID")]
            public string? reasonsForTreatmentID { get; set; }

            [JsonProperty("smfID")]
            public string? smfID { get; set; }

            [JsonProperty("patientAdm")]
            public double? patientAdm { get; set; }

            [JsonProperty("guarantorAdm")]
            public double? guarantorAdm { get; set; }

            [JsonProperty("reasonsForTreatmentDescID")]
            public string? reasonsForTreatmentDescID { get; set; }

            [JsonProperty("srReferralGroup")]
            public string? srReferralGroup { get; set; }

            [JsonProperty("srDiscountReason")]
            public string? srDiscountReason { get; set; }

            [JsonProperty("physicianSenders")]
            public string? physicianSenders { get; set; }

            [JsonProperty("discAdmPatient")]
            public double? discAdmPatient { get; set; }

            [JsonProperty("discAdmGuarantor")]
            public double? discAdmGuarantor { get; set; }

            [JsonProperty("srPatientInCondition")]
            public string? srPatientInCondition { get; set; }

            [JsonProperty("srKiaCaseType")]
            public string? srKiaCaseType { get; set; }

            [JsonProperty("srObstetricType")]
            public string? srObstetricType { get; set; }

            [JsonProperty("isHoldTransactionEntryByUserID")]
            public string? isHoldTransactionEntryByUserID { get; set; }

            [JsonProperty("fromRegistrationNo")]
            public string? fromRegistrationNo { get; set; }

            [JsonProperty("isConfirmedAttendance")]
            public bool? isConfirmedAttendance { get; set; }

            [JsonProperty("confirmedAttendanceByUserID")]
            public string? confirmedAttendanceByUserID { get; set; }

            [JsonProperty("confirmedAttendanceDateTime")]
            public DateTime? confirmedAttendanceDateTime { get; set; }

            [JsonProperty("bpjsSepNo")]
            public string? bpjsSepNo { get; set; }

            [JsonProperty("plavonAmount2")]
            public int? plavonAmount2 { get; set; }

            [JsonProperty("deathCertificateNo")]
            public string? deathCertificateNo { get; set; }

            [JsonProperty("bpjsCoverageFormula")]
            public double? bpjsCoverageFormula { get; set; }

            [JsonProperty("bpjsPackageID")]
            public string? bpjsPackageID { get; set; }

            [JsonProperty("approximatePlafondAmount")]
            public double? approximatePlafondAmount { get; set; }

            [JsonProperty("sentToBillingDateTime")]
            public DateTime? sentToBillingDateTime { get; set; }

            [JsonProperty("sentToBillingByUserID")]
            public string? sentToBillingByUserID { get; set; }

            [JsonProperty("isAdjusted")]
            public bool? isAdjusted { get; set; }

            [JsonProperty("adjustLog")]
            public string? adjustLog { get; set; }

            [JsonProperty("isAllowPatientCheckOut")]
            public bool? isAllowPatientCheckOut { get; set; }

            [JsonProperty("allowPatientCheckOutDateTime")]
            public DateTime? allowPatientCheckOutDateTime { get; set; }

            [JsonProperty("allowPatientCheckOutByUserID")]
            public string? allowPatientCheckOutByUserID { get; set; }

            [JsonProperty("referByParamedicID")]
            public string? referByParamedicID { get; set; }

            [JsonProperty("srMaritalStatus")]
            public string? srMaritalStatus { get; set; }

            [JsonProperty("srOccupation")]
            public string? srOccupation { get; set; }

            [JsonProperty("srRelationshipQuality")]
            public string? srRelationshipQuality { get; set; }

            [JsonProperty("srResidentialHome")]
            public string? srResidentialHome { get; set; }

            [JsonProperty("srFatherOccupation")]
            public string? srFatherOccupation { get; set; }

            [JsonProperty("isPregnant")]
            public bool? isPregnant { get; set; }

            [JsonProperty("gestationalAge")]
            public int? gestationalAge { get; set; }

            [JsonProperty("isBreastFeeding")]
            public bool? isBreastFeeding { get; set; }

            [JsonProperty("ageOfBabyInYear")]
            public int? ageOfBabyInYear { get; set; }

            [JsonProperty("ageOfBabyInMonth")]
            public int? ageOfBabyInMonth { get; set; }

            [JsonProperty("ageOfBabyInDay")]
            public int? ageOfBabyInDay { get; set; }

            [JsonProperty("isKidneyFunctionImpaired")]
            public bool? isKidneyFunctionImpaired { get; set; }

            [JsonProperty("creatinineSerumValue")]
            public int? creatinineSerumValue { get; set; }

            [JsonProperty("hpi")]
            public string? hpi { get; set; }

            [JsonProperty("membershipDetailID")]
            public int? membershipDetailID { get; set; }

            [JsonProperty("externalQueNo")]
            public string? externalQueNo { get; set; }

            [JsonProperty("referralIdTo")]
            public string? referralIdTo { get; set; }

            [JsonProperty("referralNameTo")]
            public string? referralNameTo { get; set; }

            [JsonProperty("isReconcile")]
            public bool? isReconcile { get; set; }

            [JsonProperty("isSkipAutoBill")]
            public bool? isSkipAutoBill { get; set; }

            [JsonProperty("srCrashSite")]
            public string? srCrashSite { get; set; }

            [JsonProperty("crashSiteDetail")]
            public string? crashSiteDetail { get; set; }

            [JsonProperty("membershipNo")]
            public string? membershipNo { get; set; }

            [JsonProperty("isOpenEntryMR")]
            public bool? isOpenEntryMR { get; set; }

            [JsonProperty("srCovidStatus")]
            public int? srCovidStatus { get; set; }

            [JsonProperty("voucherNo")]
            public string? voucherNo { get; set; }

            [JsonProperty("srCovidComorbidStatus")]
            public string? srCovidComorbidStatus { get; set; }

            [JsonProperty("isDisability")]
            public bool? isDisability { get; set; }

            [JsonProperty("isTracer")]
            public bool? isTracer { get; set; }

            [JsonProperty("itemConditionRuleID")]
            public string? itemConditionRuleID { get; set; }

            [JsonProperty("srPatientRiskStatus")]
            public string? srPatientRiskStatus { get; set; }

            [JsonProperty("isFinishedAttendance")]
            public bool? isFinishedAttendance { get; set; }

            [JsonProperty("finishedAttendanceByUserID")]
            public string? finishedAttendanceByUserID { get; set; }

            [JsonProperty("finishedAttendanceDateTime")]
            public DateTime? finishedAttendanceDateTime { get; set; }

            [JsonProperty("isQueueCalled")]
            public bool? isQueueCalled { get; set; }

            [JsonProperty("isQueueRecall")]
            public bool? isQueueRecall { get; set; }

            [JsonProperty("queueCalledDateTime")]
            public DateTime? queueCalledDateTime { get; set; }

            [JsonProperty("srQueRoom")]
            public string? srQueRoom { get; set; }

            [JsonProperty("srClassification")]
            public string? srClassification { get; set; }

            [JsonProperty("srClassificationRoom")]
            public string? srClassificationRoom { get; set; }

            [JsonProperty("queueQr")]
            public string? queueQr { get; set; }

            [JsonProperty("srPatientRiskColor")]
            public string? srPatientRiskColor { get; set; }
        }
    }
}

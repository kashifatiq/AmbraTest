using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmraLibrary.AmbraModels
{
    public class Study
    {
        public string study_description { get; set; }
        public object patient_current_location { get; set; }
        public object patient_occupation { get; set; }
        public int phantom { get; set; }
        public object patientid_other { get; set; }
        public string patient_birth_date { get; set; }
        public int is_dicom_wrapped { get; set; }
        public string engine_fqdn { get; set; }
        public string study_date { get; set; }
        public int must_approve { get; set; }
        public object patient_name_other { get; set; }
        public int image_count { get; set; }
        public string patient_address { get; set; }
        public object integration_key { get; set; }
        public object source_ae_title { get; set; }
        public object compressed_size { get; set; }
        public string created { get; set; }
        public object patient_mother_birthname { get; set; }
        public string viewer_link { get; set; }
        public Permissions permissions { get; set; }
        public string patient_size { get; set; }
        public List<object> hl7 { get; set; }
        public string patientid { get; set; }
        public object destination_ae_title { get; set; }
        public string patient_weight { get; set; }
        public string patient_comments { get; set; }
        public List<string> study_status_tags { get; set; }
        public object patient_religious_preference { get; set; }
        public object study_status { get; set; }
        public string study_time { get; set; }
        public object patient_institution_residence { get; set; }
        public int star { get; set; }
        public string patient_name { get; set; }
        public object patient_birth_time { get; set; }
        public string phi_namespace { get; set; }
        public object patient_ethnic_group { get; set; }
        public string uuid { get; set; }
        public int attachment_count { get; set; }
        public string updated { get; set; }
        public int thin { get; set; }
        public List<object> radreports { get; set; }
        public string study_uid { get; set; }
        public object patient_phone { get; set; }
        public string source { get; set; }
        public string referring_physician { get; set; }
        public object local_storage_vm { get; set; }
        public List<Route> routes { get; set; }
        public string share_message { get; set; }
        public string patient_age { get; set; }
        public string accession_number { get; set; }
        public string phi_namespace_name { get; set; }
        public string patient_sex { get; set; }
        public object medical_record_locator { get; set; }
        public string size { get; set; }
        public string modality { get; set; }
        public object patient_birthname { get; set; }
        public string patient_additional_history { get; set; }
        public string storage_namespace { get; set; }
    }
}
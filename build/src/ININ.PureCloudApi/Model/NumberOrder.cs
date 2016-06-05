using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// NumberOrder
    /// </summary>
    [DataContract]
    public partial class NumberOrder :  IEquatable<NumberOrder>
    {
        /// <summary>
        /// Current status of this DID order
        /// </summary>
        /// <value>Current status of this DID order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Complete for "COMPLETE"
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            Complete,
            
            /// <summary>
            /// Enum Connecting for "CONNECTING"
            /// </summary>
            [EnumMember(Value = "CONNECTING")]
            Connecting,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum Backordered for "BACKORDERED"
            /// </summary>
            [EnumMember(Value = "BACKORDERED")]
            Backordered,
            
            /// <summary>
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Activating for "ACTIVATING"
            /// </summary>
            [EnumMember(Value = "ACTIVATING")]
            Activating,
            
            /// <summary>
            /// Enum ActivationError for "ACTIVATION_ERROR"
            /// </summary>
            [EnumMember(Value = "ACTIVATION_ERROR")]
            ActivationError,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Disconnected for "DISCONNECTED"
            /// </summary>
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            /// <summary>
            /// Enum DisconnectPending for "DISCONNECT_PENDING"
            /// </summary>
            [EnumMember(Value = "DISCONNECT_PENDING")]
            DisconnectPending,
            
            /// <summary>
            /// Enum Deactivating for "DEACTIVATING"
            /// </summary>
            [EnumMember(Value = "DEACTIVATING")]
            Deactivating,
            
            /// <summary>
            /// Enum DeactivationError for "DEACTIVATION_ERROR"
            /// </summary>
            [EnumMember(Value = "DEACTIVATION_ERROR")]
            DeactivationError,
            
            /// <summary>
            /// Enum DisconnectFailed for "DISCONNECT_FAILED"
            /// </summary>
            [EnumMember(Value = "DISCONNECT_FAILED")]
            DisconnectFailed,
            
            /// <summary>
            /// Enum Submitted for "SUBMITTED"
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            Submitted,
            
            /// <summary>
            /// Enum Rejected for "REJECTED"
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            Rejected,
            
            /// <summary>
            /// Enum Supp for "SUPP"
            /// </summary>
            [EnumMember(Value = "SUPP")]
            Supp,
            
            /// <summary>
            /// Enum PortPending for "PORT_PENDING"
            /// </summary>
            [EnumMember(Value = "PORT_PENDING")]
            PortPending,
            
            /// <summary>
            /// Enum Foc for "FOC"
            /// </summary>
            [EnumMember(Value = "FOC")]
            Foc
        }

        /// <summary>
        /// Class of DID being purchased (eg. us-domestic, toll-free, etc)
        /// </summary>
        /// <value>Class of DID being purchased (eg. us-domestic, toll-free, etc)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneNumberTypeEnum
        {
            
            /// <summary>
            /// Enum TollFree for "TOLL_FREE"
            /// </summary>
            [EnumMember(Value = "TOLL_FREE")]
            TollFree,
            
            /// <summary>
            /// Enum CnDomestic for "CN_DOMESTIC"
            /// </summary>
            [EnumMember(Value = "CN_DOMESTIC")]
            CnDomestic,
            
            /// <summary>
            /// Enum UsDomestic for "US_DOMESTIC"
            /// </summary>
            [EnumMember(Value = "US_DOMESTIC")]
            UsDomestic,
            
            /// <summary>
            /// Enum UsTollfree for "US_TOLLFREE"
            /// </summary>
            [EnumMember(Value = "US_TOLLFREE")]
            UsTollfree,
            
            /// <summary>
            /// Enum XaTollfree for "XA_TOLLFREE"
            /// </summary>
            [EnumMember(Value = "XA_TOLLFREE")]
            XaTollfree,
            
            /// <summary>
            /// Enum XbTollfree for "XB_TOLLFREE"
            /// </summary>
            [EnumMember(Value = "XB_TOLLFREE")]
            XbTollfree,
            
            /// <summary>
            /// Enum XcTollfree for "XC_TOLLFREE"
            /// </summary>
            [EnumMember(Value = "XC_TOLLFREE")]
            XcTollfree,
            
            /// <summary>
            /// Enum AgDid for "AG_DID"
            /// </summary>
            [EnumMember(Value = "AG_DID")]
            AgDid,
            
            /// <summary>
            /// Enum AiDid for "AI_DID"
            /// </summary>
            [EnumMember(Value = "AI_DID")]
            AiDid,
            
            /// <summary>
            /// Enum BbDid for "BB_DID"
            /// </summary>
            [EnumMember(Value = "BB_DID")]
            BbDid,
            
            /// <summary>
            /// Enum BmDid for "BM_DID"
            /// </summary>
            [EnumMember(Value = "BM_DID")]
            BmDid,
            
            /// <summary>
            /// Enum BsDid for "BS_DID"
            /// </summary>
            [EnumMember(Value = "BS_DID")]
            BsDid,
            
            /// <summary>
            /// Enum CaDid for "CA_DID"
            /// </summary>
            [EnumMember(Value = "CA_DID")]
            CaDid,
            
            /// <summary>
            /// Enum DmDid for "DM_DID"
            /// </summary>
            [EnumMember(Value = "DM_DID")]
            DmDid,
            
            /// <summary>
            /// Enum DoDid for "DO_DID"
            /// </summary>
            [EnumMember(Value = "DO_DID")]
            DoDid,
            
            /// <summary>
            /// Enum GdDid for "GD_DID"
            /// </summary>
            [EnumMember(Value = "GD_DID")]
            GdDid,
            
            /// <summary>
            /// Enum JmDid for "JM_DID"
            /// </summary>
            [EnumMember(Value = "JM_DID")]
            JmDid,
            
            /// <summary>
            /// Enum KnDid for "KN_DID"
            /// </summary>
            [EnumMember(Value = "KN_DID")]
            KnDid,
            
            /// <summary>
            /// Enum KyDid for "KY_DID"
            /// </summary>
            [EnumMember(Value = "KY_DID")]
            KyDid,
            
            /// <summary>
            /// Enum KzDid for "KZ_DID"
            /// </summary>
            [EnumMember(Value = "KZ_DID")]
            KzDid,
            
            /// <summary>
            /// Enum LcDid for "LC_DID"
            /// </summary>
            [EnumMember(Value = "LC_DID")]
            LcDid,
            
            /// <summary>
            /// Enum MpDid for "MP_DID"
            /// </summary>
            [EnumMember(Value = "MP_DID")]
            MpDid,
            
            /// <summary>
            /// Enum MsDid for "MS_DID"
            /// </summary>
            [EnumMember(Value = "MS_DID")]
            MsDid,
            
            /// <summary>
            /// Enum RuDid for "RU_DID"
            /// </summary>
            [EnumMember(Value = "RU_DID")]
            RuDid,
            
            /// <summary>
            /// Enum TcDid for "TC_DID"
            /// </summary>
            [EnumMember(Value = "TC_DID")]
            TcDid,
            
            /// <summary>
            /// Enum TtDid for "TT_DID"
            /// </summary>
            [EnumMember(Value = "TT_DID")]
            TtDid,
            
            /// <summary>
            /// Enum UsDid for "US_DID"
            /// </summary>
            [EnumMember(Value = "US_DID")]
            UsDid,
            
            /// <summary>
            /// Enum VcDid for "VC_DID"
            /// </summary>
            [EnumMember(Value = "VC_DID")]
            VcDid,
            
            /// <summary>
            /// Enum VgDid for "VG_DID"
            /// </summary>
            [EnumMember(Value = "VG_DID")]
            VgDid,
            
            /// <summary>
            /// Enum AfDid for "AF_DID"
            /// </summary>
            [EnumMember(Value = "AF_DID")]
            AfDid,
            
            /// <summary>
            /// Enum ArDid for "AR_DID"
            /// </summary>
            [EnumMember(Value = "AR_DID")]
            ArDid,
            
            /// <summary>
            /// Enum AtDid for "AT_DID"
            /// </summary>
            [EnumMember(Value = "AT_DID")]
            AtDid,
            
            /// <summary>
            /// Enum AuDid for "AU_DID"
            /// </summary>
            [EnumMember(Value = "AU_DID")]
            AuDid,
            
            /// <summary>
            /// Enum BeDid for "BE_DID"
            /// </summary>
            [EnumMember(Value = "BE_DID")]
            BeDid,
            
            /// <summary>
            /// Enum BrDid for "BR_DID"
            /// </summary>
            [EnumMember(Value = "BR_DID")]
            BrDid,
            
            /// <summary>
            /// Enum ChDid for "CH_DID"
            /// </summary>
            [EnumMember(Value = "CH_DID")]
            ChDid,
            
            /// <summary>
            /// Enum ClDid for "CL_DID"
            /// </summary>
            [EnumMember(Value = "CL_DID")]
            ClDid,
            
            /// <summary>
            /// Enum CnDid for "CN_DID"
            /// </summary>
            [EnumMember(Value = "CN_DID")]
            CnDid,
            
            /// <summary>
            /// Enum CoDid for "CO_DID"
            /// </summary>
            [EnumMember(Value = "CO_DID")]
            CoDid,
            
            /// <summary>
            /// Enum CuDid for "CU_DID"
            /// </summary>
            [EnumMember(Value = "CU_DID")]
            CuDid,
            
            /// <summary>
            /// Enum DeDid for "DE_DID"
            /// </summary>
            [EnumMember(Value = "DE_DID")]
            DeDid,
            
            /// <summary>
            /// Enum DkDid for "DK_DID"
            /// </summary>
            [EnumMember(Value = "DK_DID")]
            DkDid,
            
            /// <summary>
            /// Enum EgDid for "EG_DID"
            /// </summary>
            [EnumMember(Value = "EG_DID")]
            EgDid,
            
            /// <summary>
            /// Enum EsDid for "ES_DID"
            /// </summary>
            [EnumMember(Value = "ES_DID")]
            EsDid,
            
            /// <summary>
            /// Enum FrDid for "FR_DID"
            /// </summary>
            [EnumMember(Value = "FR_DID")]
            FrDid,
            
            /// <summary>
            /// Enum GbDid for "GB_DID"
            /// </summary>
            [EnumMember(Value = "GB_DID")]
            GbDid,
            
            /// <summary>
            /// Enum GrDid for "GR_DID"
            /// </summary>
            [EnumMember(Value = "GR_DID")]
            GrDid,
            
            /// <summary>
            /// Enum HuDid for "HU_DID"
            /// </summary>
            [EnumMember(Value = "HU_DID")]
            HuDid,
            
            /// <summary>
            /// Enum IdDid for "ID_DID"
            /// </summary>
            [EnumMember(Value = "ID_DID")]
            IdDid,
            
            /// <summary>
            /// Enum InDid for "IN_DID"
            /// </summary>
            [EnumMember(Value = "IN_DID")]
            InDid,
            
            /// <summary>
            /// Enum IrDid for "IR_DID"
            /// </summary>
            [EnumMember(Value = "IR_DID")]
            IrDid,
            
            /// <summary>
            /// Enum ItDid for "IT_DID"
            /// </summary>
            [EnumMember(Value = "IT_DID")]
            ItDid,
            
            /// <summary>
            /// Enum JpDid for "JP_DID"
            /// </summary>
            [EnumMember(Value = "JP_DID")]
            JpDid,
            
            /// <summary>
            /// Enum KrDid for "KR_DID"
            /// </summary>
            [EnumMember(Value = "KR_DID")]
            KrDid,
            
            /// <summary>
            /// Enum LkDid for "LK_DID"
            /// </summary>
            [EnumMember(Value = "LK_DID")]
            LkDid,
            
            /// <summary>
            /// Enum MmDid for "MM_DID"
            /// </summary>
            [EnumMember(Value = "MM_DID")]
            MmDid,
            
            /// <summary>
            /// Enum MxDid for "MX_DID"
            /// </summary>
            [EnumMember(Value = "MX_DID")]
            MxDid,
            
            /// <summary>
            /// Enum MyDid for "MY_DID"
            /// </summary>
            [EnumMember(Value = "MY_DID")]
            MyDid,
            
            /// <summary>
            /// Enum NlDid for "NL_DID"
            /// </summary>
            [EnumMember(Value = "NL_DID")]
            NlDid,
            
            /// <summary>
            /// Enum NoDid for "NO_DID"
            /// </summary>
            [EnumMember(Value = "NO_DID")]
            NoDid,
            
            /// <summary>
            /// Enum NzDid for "NZ_DID"
            /// </summary>
            [EnumMember(Value = "NZ_DID")]
            NzDid,
            
            /// <summary>
            /// Enum PeDid for "PE_DID"
            /// </summary>
            [EnumMember(Value = "PE_DID")]
            PeDid,
            
            /// <summary>
            /// Enum PhDid for "PH_DID"
            /// </summary>
            [EnumMember(Value = "PH_DID")]
            PhDid,
            
            /// <summary>
            /// Enum PkDid for "PK_DID"
            /// </summary>
            [EnumMember(Value = "PK_DID")]
            PkDid,
            
            /// <summary>
            /// Enum PlDid for "PL_DID"
            /// </summary>
            [EnumMember(Value = "PL_DID")]
            PlDid,
            
            /// <summary>
            /// Enum RoDid for "RO_DID"
            /// </summary>
            [EnumMember(Value = "RO_DID")]
            RoDid,
            
            /// <summary>
            /// Enum SeDid for "SE_DID"
            /// </summary>
            [EnumMember(Value = "SE_DID")]
            SeDid,
            
            /// <summary>
            /// Enum SgDid for "SG_DID"
            /// </summary>
            [EnumMember(Value = "SG_DID")]
            SgDid,
            
            /// <summary>
            /// Enum ThDid for "TH_DID"
            /// </summary>
            [EnumMember(Value = "TH_DID")]
            ThDid,
            
            /// <summary>
            /// Enum TrDid for "TR_DID"
            /// </summary>
            [EnumMember(Value = "TR_DID")]
            TrDid,
            
            /// <summary>
            /// Enum VeDid for "VE_DID"
            /// </summary>
            [EnumMember(Value = "VE_DID")]
            VeDid,
            
            /// <summary>
            /// Enum VnDid for "VN_DID"
            /// </summary>
            [EnumMember(Value = "VN_DID")]
            VnDid,
            
            /// <summary>
            /// Enum ZaDid for "ZA_DID"
            /// </summary>
            [EnumMember(Value = "ZA_DID")]
            ZaDid,
            
            /// <summary>
            /// Enum AdDid for "AD_DID"
            /// </summary>
            [EnumMember(Value = "AD_DID")]
            AdDid,
            
            /// <summary>
            /// Enum AeDid for "AE_DID"
            /// </summary>
            [EnumMember(Value = "AE_DID")]
            AeDid,
            
            /// <summary>
            /// Enum AlDid for "AL_DID"
            /// </summary>
            [EnumMember(Value = "AL_DID")]
            AlDid,
            
            /// <summary>
            /// Enum AmDid for "AM_DID"
            /// </summary>
            [EnumMember(Value = "AM_DID")]
            AmDid,
            
            /// <summary>
            /// Enum AoDid for "AO_DID"
            /// </summary>
            [EnumMember(Value = "AO_DID")]
            AoDid,
            
            /// <summary>
            /// Enum AqDid for "AQ_DID"
            /// </summary>
            [EnumMember(Value = "AQ_DID")]
            AqDid,
            
            /// <summary>
            /// Enum AwDid for "AW_DID"
            /// </summary>
            [EnumMember(Value = "AW_DID")]
            AwDid,
            
            /// <summary>
            /// Enum AzDid for "AZ_DID"
            /// </summary>
            [EnumMember(Value = "AZ_DID")]
            AzDid,
            
            /// <summary>
            /// Enum BaDid for "BA_DID"
            /// </summary>
            [EnumMember(Value = "BA_DID")]
            BaDid,
            
            /// <summary>
            /// Enum BdDid for "BD_DID"
            /// </summary>
            [EnumMember(Value = "BD_DID")]
            BdDid,
            
            /// <summary>
            /// Enum BfDid for "BF_DID"
            /// </summary>
            [EnumMember(Value = "BF_DID")]
            BfDid,
            
            /// <summary>
            /// Enum BgDid for "BG_DID"
            /// </summary>
            [EnumMember(Value = "BG_DID")]
            BgDid,
            
            /// <summary>
            /// Enum BhDid for "BH_DID"
            /// </summary>
            [EnumMember(Value = "BH_DID")]
            BhDid,
            
            /// <summary>
            /// Enum BiDid for "BI_DID"
            /// </summary>
            [EnumMember(Value = "BI_DID")]
            BiDid,
            
            /// <summary>
            /// Enum BjDid for "BJ_DID"
            /// </summary>
            [EnumMember(Value = "BJ_DID")]
            BjDid,
            
            /// <summary>
            /// Enum BlDid for "BL_DID"
            /// </summary>
            [EnumMember(Value = "BL_DID")]
            BlDid,
            
            /// <summary>
            /// Enum BnDid for "BN_DID"
            /// </summary>
            [EnumMember(Value = "BN_DID")]
            BnDid,
            
            /// <summary>
            /// Enum BoDid for "BO_DID"
            /// </summary>
            [EnumMember(Value = "BO_DID")]
            BoDid,
            
            /// <summary>
            /// Enum BqDid for "BQ_DID"
            /// </summary>
            [EnumMember(Value = "BQ_DID")]
            BqDid,
            
            /// <summary>
            /// Enum BtDid for "BT_DID"
            /// </summary>
            [EnumMember(Value = "BT_DID")]
            BtDid,
            
            /// <summary>
            /// Enum BwDid for "BW_DID"
            /// </summary>
            [EnumMember(Value = "BW_DID")]
            BwDid,
            
            /// <summary>
            /// Enum ByDid for "BY_DID"
            /// </summary>
            [EnumMember(Value = "BY_DID")]
            ByDid,
            
            /// <summary>
            /// Enum BzDid for "BZ_DID"
            /// </summary>
            [EnumMember(Value = "BZ_DID")]
            BzDid,
            
            /// <summary>
            /// Enum CdDid for "CD_DID"
            /// </summary>
            [EnumMember(Value = "CD_DID")]
            CdDid,
            
            /// <summary>
            /// Enum CfDid for "CF_DID"
            /// </summary>
            [EnumMember(Value = "CF_DID")]
            CfDid,
            
            /// <summary>
            /// Enum CgDid for "CG_DID"
            /// </summary>
            [EnumMember(Value = "CG_DID")]
            CgDid,
            
            /// <summary>
            /// Enum CiDid for "CI_DID"
            /// </summary>
            [EnumMember(Value = "CI_DID")]
            CiDid,
            
            /// <summary>
            /// Enum CkDid for "CK_DID"
            /// </summary>
            [EnumMember(Value = "CK_DID")]
            CkDid,
            
            /// <summary>
            /// Enum CmDid for "CM_DID"
            /// </summary>
            [EnumMember(Value = "CM_DID")]
            CmDid,
            
            /// <summary>
            /// Enum CrDid for "CR_DID"
            /// </summary>
            [EnumMember(Value = "CR_DID")]
            CrDid,
            
            /// <summary>
            /// Enum CvDid for "CV_DID"
            /// </summary>
            [EnumMember(Value = "CV_DID")]
            CvDid,
            
            /// <summary>
            /// Enum CyDid for "CY_DID"
            /// </summary>
            [EnumMember(Value = "CY_DID")]
            CyDid,
            
            /// <summary>
            /// Enum CzDid for "CZ_DID"
            /// </summary>
            [EnumMember(Value = "CZ_DID")]
            CzDid,
            
            /// <summary>
            /// Enum DjDid for "DJ_DID"
            /// </summary>
            [EnumMember(Value = "DJ_DID")]
            DjDid,
            
            /// <summary>
            /// Enum DzDid for "DZ_DID"
            /// </summary>
            [EnumMember(Value = "DZ_DID")]
            DzDid,
            
            /// <summary>
            /// Enum EcDid for "EC_DID"
            /// </summary>
            [EnumMember(Value = "EC_DID")]
            EcDid,
            
            /// <summary>
            /// Enum EeDid for "EE_DID"
            /// </summary>
            [EnumMember(Value = "EE_DID")]
            EeDid,
            
            /// <summary>
            /// Enum EhDid for "EH_DID"
            /// </summary>
            [EnumMember(Value = "EH_DID")]
            EhDid,
            
            /// <summary>
            /// Enum ErDid for "ER_DID"
            /// </summary>
            [EnumMember(Value = "ER_DID")]
            ErDid,
            
            /// <summary>
            /// Enum EtDid for "ET_DID"
            /// </summary>
            [EnumMember(Value = "ET_DID")]
            EtDid,
            
            /// <summary>
            /// Enum FiDid for "FI_DID"
            /// </summary>
            [EnumMember(Value = "FI_DID")]
            FiDid,
            
            /// <summary>
            /// Enum FjDid for "FJ_DID"
            /// </summary>
            [EnumMember(Value = "FJ_DID")]
            FjDid,
            
            /// <summary>
            /// Enum FkDid for "FK_DID"
            /// </summary>
            [EnumMember(Value = "FK_DID")]
            FkDid,
            
            /// <summary>
            /// Enum FmDid for "FM_DID"
            /// </summary>
            [EnumMember(Value = "FM_DID")]
            FmDid,
            
            /// <summary>
            /// Enum FoDid for "FO_DID"
            /// </summary>
            [EnumMember(Value = "FO_DID")]
            FoDid,
            
            /// <summary>
            /// Enum GaDid for "GA_DID"
            /// </summary>
            [EnumMember(Value = "GA_DID")]
            GaDid,
            
            /// <summary>
            /// Enum GeDid for "GE_DID"
            /// </summary>
            [EnumMember(Value = "GE_DID")]
            GeDid,
            
            /// <summary>
            /// Enum GfDid for "GF_DID"
            /// </summary>
            [EnumMember(Value = "GF_DID")]
            GfDid,
            
            /// <summary>
            /// Enum GhDid for "GH_DID"
            /// </summary>
            [EnumMember(Value = "GH_DID")]
            GhDid,
            
            /// <summary>
            /// Enum GiDid for "GI_DID"
            /// </summary>
            [EnumMember(Value = "GI_DID")]
            GiDid,
            
            /// <summary>
            /// Enum GlDid for "GL_DID"
            /// </summary>
            [EnumMember(Value = "GL_DID")]
            GlDid,
            
            /// <summary>
            /// Enum GmDid for "GM_DID"
            /// </summary>
            [EnumMember(Value = "GM_DID")]
            GmDid,
            
            /// <summary>
            /// Enum GnDid for "GN_DID"
            /// </summary>
            [EnumMember(Value = "GN_DID")]
            GnDid,
            
            /// <summary>
            /// Enum GpDid for "GP_DID"
            /// </summary>
            [EnumMember(Value = "GP_DID")]
            GpDid,
            
            /// <summary>
            /// Enum GqDid for "GQ_DID"
            /// </summary>
            [EnumMember(Value = "GQ_DID")]
            GqDid,
            
            /// <summary>
            /// Enum GtDid for "GT_DID"
            /// </summary>
            [EnumMember(Value = "GT_DID")]
            GtDid,
            
            /// <summary>
            /// Enum GwDid for "GW_DID"
            /// </summary>
            [EnumMember(Value = "GW_DID")]
            GwDid,
            
            /// <summary>
            /// Enum GyDid for "GY_DID"
            /// </summary>
            [EnumMember(Value = "GY_DID")]
            GyDid,
            
            /// <summary>
            /// Enum HkDid for "HK_DID"
            /// </summary>
            [EnumMember(Value = "HK_DID")]
            HkDid,
            
            /// <summary>
            /// Enum HnDid for "HN_DID"
            /// </summary>
            [EnumMember(Value = "HN_DID")]
            HnDid,
            
            /// <summary>
            /// Enum HrDid for "HR_DID"
            /// </summary>
            [EnumMember(Value = "HR_DID")]
            HrDid,
            
            /// <summary>
            /// Enum HtDid for "HT_DID"
            /// </summary>
            [EnumMember(Value = "HT_DID")]
            HtDid,
            
            /// <summary>
            /// Enum IeDid for "IE_DID"
            /// </summary>
            [EnumMember(Value = "IE_DID")]
            IeDid,
            
            /// <summary>
            /// Enum IlDid for "IL_DID"
            /// </summary>
            [EnumMember(Value = "IL_DID")]
            IlDid,
            
            /// <summary>
            /// Enum IoDid for "IO_DID"
            /// </summary>
            [EnumMember(Value = "IO_DID")]
            IoDid,
            
            /// <summary>
            /// Enum IqDid for "IQ_DID"
            /// </summary>
            [EnumMember(Value = "IQ_DID")]
            IqDid,
            
            /// <summary>
            /// Enum IsDid for "IS_DID"
            /// </summary>
            [EnumMember(Value = "IS_DID")]
            IsDid,
            
            /// <summary>
            /// Enum JoDid for "JO_DID"
            /// </summary>
            [EnumMember(Value = "JO_DID")]
            JoDid,
            
            /// <summary>
            /// Enum KeDid for "KE_DID"
            /// </summary>
            [EnumMember(Value = "KE_DID")]
            KeDid,
            
            /// <summary>
            /// Enum KgDid for "KG_DID"
            /// </summary>
            [EnumMember(Value = "KG_DID")]
            KgDid,
            
            /// <summary>
            /// Enum KhDid for "KH_DID"
            /// </summary>
            [EnumMember(Value = "KH_DID")]
            KhDid,
            
            /// <summary>
            /// Enum KiDid for "KI_DID"
            /// </summary>
            [EnumMember(Value = "KI_DID")]
            KiDid,
            
            /// <summary>
            /// Enum KmDid for "KM_DID"
            /// </summary>
            [EnumMember(Value = "KM_DID")]
            KmDid,
            
            /// <summary>
            /// Enum KpDid for "KP_DID"
            /// </summary>
            [EnumMember(Value = "KP_DID")]
            KpDid,
            
            /// <summary>
            /// Enum KwDid for "KW_DID"
            /// </summary>
            [EnumMember(Value = "KW_DID")]
            KwDid,
            
            /// <summary>
            /// Enum LaDid for "LA_DID"
            /// </summary>
            [EnumMember(Value = "LA_DID")]
            LaDid,
            
            /// <summary>
            /// Enum LbDid for "LB_DID"
            /// </summary>
            [EnumMember(Value = "LB_DID")]
            LbDid,
            
            /// <summary>
            /// Enum LiDid for "LI_DID"
            /// </summary>
            [EnumMember(Value = "LI_DID")]
            LiDid,
            
            /// <summary>
            /// Enum LrDid for "LR_DID"
            /// </summary>
            [EnumMember(Value = "LR_DID")]
            LrDid,
            
            /// <summary>
            /// Enum LsDid for "LS_DID"
            /// </summary>
            [EnumMember(Value = "LS_DID")]
            LsDid,
            
            /// <summary>
            /// Enum LtDid for "LT_DID"
            /// </summary>
            [EnumMember(Value = "LT_DID")]
            LtDid,
            
            /// <summary>
            /// Enum LuDid for "LU_DID"
            /// </summary>
            [EnumMember(Value = "LU_DID")]
            LuDid,
            
            /// <summary>
            /// Enum LvDid for "LV_DID"
            /// </summary>
            [EnumMember(Value = "LV_DID")]
            LvDid,
            
            /// <summary>
            /// Enum LyDid for "LY_DID"
            /// </summary>
            [EnumMember(Value = "LY_DID")]
            LyDid,
            
            /// <summary>
            /// Enum MaDid for "MA_DID"
            /// </summary>
            [EnumMember(Value = "MA_DID")]
            MaDid,
            
            /// <summary>
            /// Enum McDid for "MC_DID"
            /// </summary>
            [EnumMember(Value = "MC_DID")]
            McDid,
            
            /// <summary>
            /// Enum MdDid for "MD_DID"
            /// </summary>
            [EnumMember(Value = "MD_DID")]
            MdDid,
            
            /// <summary>
            /// Enum MeDid for "ME_DID"
            /// </summary>
            [EnumMember(Value = "ME_DID")]
            MeDid,
            
            /// <summary>
            /// Enum MfDid for "MF_DID"
            /// </summary>
            [EnumMember(Value = "MF_DID")]
            MfDid,
            
            /// <summary>
            /// Enum MgDid for "MG_DID"
            /// </summary>
            [EnumMember(Value = "MG_DID")]
            MgDid,
            
            /// <summary>
            /// Enum MhDid for "MH_DID"
            /// </summary>
            [EnumMember(Value = "MH_DID")]
            MhDid,
            
            /// <summary>
            /// Enum MkDid for "MK_DID"
            /// </summary>
            [EnumMember(Value = "MK_DID")]
            MkDid,
            
            /// <summary>
            /// Enum MlDid for "ML_DID"
            /// </summary>
            [EnumMember(Value = "ML_DID")]
            MlDid,
            
            /// <summary>
            /// Enum MnDid for "MN_DID"
            /// </summary>
            [EnumMember(Value = "MN_DID")]
            MnDid,
            
            /// <summary>
            /// Enum MoDid for "MO_DID"
            /// </summary>
            [EnumMember(Value = "MO_DID")]
            MoDid,
            
            /// <summary>
            /// Enum MqDid for "MQ_DID"
            /// </summary>
            [EnumMember(Value = "MQ_DID")]
            MqDid,
            
            /// <summary>
            /// Enum MrDid for "MR_DID"
            /// </summary>
            [EnumMember(Value = "MR_DID")]
            MrDid,
            
            /// <summary>
            /// Enum MtDid for "MT_DID"
            /// </summary>
            [EnumMember(Value = "MT_DID")]
            MtDid,
            
            /// <summary>
            /// Enum MuDid for "MU_DID"
            /// </summary>
            [EnumMember(Value = "MU_DID")]
            MuDid,
            
            /// <summary>
            /// Enum MvDid for "MV_DID"
            /// </summary>
            [EnumMember(Value = "MV_DID")]
            MvDid,
            
            /// <summary>
            /// Enum MwDid for "MW_DID"
            /// </summary>
            [EnumMember(Value = "MW_DID")]
            MwDid,
            
            /// <summary>
            /// Enum MzDid for "MZ_DID"
            /// </summary>
            [EnumMember(Value = "MZ_DID")]
            MzDid,
            
            /// <summary>
            /// Enum NaDid for "NA_DID"
            /// </summary>
            [EnumMember(Value = "NA_DID")]
            NaDid,
            
            /// <summary>
            /// Enum NcDid for "NC_DID"
            /// </summary>
            [EnumMember(Value = "NC_DID")]
            NcDid,
            
            /// <summary>
            /// Enum NeDid for "NE_DID"
            /// </summary>
            [EnumMember(Value = "NE_DID")]
            NeDid,
            
            /// <summary>
            /// Enum NfDid for "NF_DID"
            /// </summary>
            [EnumMember(Value = "NF_DID")]
            NfDid,
            
            /// <summary>
            /// Enum NgDid for "NG_DID"
            /// </summary>
            [EnumMember(Value = "NG_DID")]
            NgDid,
            
            /// <summary>
            /// Enum NiDid for "NI_DID"
            /// </summary>
            [EnumMember(Value = "NI_DID")]
            NiDid,
            
            /// <summary>
            /// Enum NpDid for "NP_DID"
            /// </summary>
            [EnumMember(Value = "NP_DID")]
            NpDid,
            
            /// <summary>
            /// Enum NrDid for "NR_DID"
            /// </summary>
            [EnumMember(Value = "NR_DID")]
            NrDid,
            
            /// <summary>
            /// Enum NuDid for "NU_DID"
            /// </summary>
            [EnumMember(Value = "NU_DID")]
            NuDid,
            
            /// <summary>
            /// Enum OmDid for "OM_DID"
            /// </summary>
            [EnumMember(Value = "OM_DID")]
            OmDid,
            
            /// <summary>
            /// Enum PaDid for "PA_DID"
            /// </summary>
            [EnumMember(Value = "PA_DID")]
            PaDid,
            
            /// <summary>
            /// Enum PfDid for "PF_DID"
            /// </summary>
            [EnumMember(Value = "PF_DID")]
            PfDid,
            
            /// <summary>
            /// Enum PgDid for "PG_DID"
            /// </summary>
            [EnumMember(Value = "PG_DID")]
            PgDid,
            
            /// <summary>
            /// Enum PmDid for "PM_DID"
            /// </summary>
            [EnumMember(Value = "PM_DID")]
            PmDid,
            
            /// <summary>
            /// Enum PsDid for "PS_DID"
            /// </summary>
            [EnumMember(Value = "PS_DID")]
            PsDid,
            
            /// <summary>
            /// Enum PtDid for "PT_DID"
            /// </summary>
            [EnumMember(Value = "PT_DID")]
            PtDid,
            
            /// <summary>
            /// Enum PwDid for "PW_DID"
            /// </summary>
            [EnumMember(Value = "PW_DID")]
            PwDid,
            
            /// <summary>
            /// Enum PyDid for "PY_DID"
            /// </summary>
            [EnumMember(Value = "PY_DID")]
            PyDid,
            
            /// <summary>
            /// Enum QaDid for "QA_DID"
            /// </summary>
            [EnumMember(Value = "QA_DID")]
            QaDid,
            
            /// <summary>
            /// Enum ReDid for "RE_DID"
            /// </summary>
            [EnumMember(Value = "RE_DID")]
            ReDid,
            
            /// <summary>
            /// Enum RsDid for "RS_DID"
            /// </summary>
            [EnumMember(Value = "RS_DID")]
            RsDid,
            
            /// <summary>
            /// Enum RwDid for "RW_DID"
            /// </summary>
            [EnumMember(Value = "RW_DID")]
            RwDid,
            
            /// <summary>
            /// Enum SaDid for "SA_DID"
            /// </summary>
            [EnumMember(Value = "SA_DID")]
            SaDid,
            
            /// <summary>
            /// Enum SbDid for "SB_DID"
            /// </summary>
            [EnumMember(Value = "SB_DID")]
            SbDid,
            
            /// <summary>
            /// Enum ScDid for "SC_DID"
            /// </summary>
            [EnumMember(Value = "SC_DID")]
            ScDid,
            
            /// <summary>
            /// Enum SdDid for "SD_DID"
            /// </summary>
            [EnumMember(Value = "SD_DID")]
            SdDid,
            
            /// <summary>
            /// Enum Sh247Did for "SH_247_DID"
            /// </summary>
            [EnumMember(Value = "SH_247_DID")]
            Sh247Did,
            
            /// <summary>
            /// Enum Sh290Did for "SH_290_DID"
            /// </summary>
            [EnumMember(Value = "SH_290_DID")]
            Sh290Did,
            
            /// <summary>
            /// Enum SiDid for "SI_DID"
            /// </summary>
            [EnumMember(Value = "SI_DID")]
            SiDid,
            
            /// <summary>
            /// Enum SkDid for "SK_DID"
            /// </summary>
            [EnumMember(Value = "SK_DID")]
            SkDid,
            
            /// <summary>
            /// Enum SlDid for "SL_DID"
            /// </summary>
            [EnumMember(Value = "SL_DID")]
            SlDid,
            
            /// <summary>
            /// Enum SmDid for "SM_DID"
            /// </summary>
            [EnumMember(Value = "SM_DID")]
            SmDid,
            
            /// <summary>
            /// Enum SnDid for "SN_DID"
            /// </summary>
            [EnumMember(Value = "SN_DID")]
            SnDid,
            
            /// <summary>
            /// Enum SoDid for "SO_DID"
            /// </summary>
            [EnumMember(Value = "SO_DID")]
            SoDid,
            
            /// <summary>
            /// Enum SrDid for "SR_DID"
            /// </summary>
            [EnumMember(Value = "SR_DID")]
            SrDid,
            
            /// <summary>
            /// Enum SsDid for "SS_DID"
            /// </summary>
            [EnumMember(Value = "SS_DID")]
            SsDid,
            
            /// <summary>
            /// Enum StDid for "ST_DID"
            /// </summary>
            [EnumMember(Value = "ST_DID")]
            StDid,
            
            /// <summary>
            /// Enum SvDid for "SV_DID"
            /// </summary>
            [EnumMember(Value = "SV_DID")]
            SvDid,
            
            /// <summary>
            /// Enum SyDid for "SY_DID"
            /// </summary>
            [EnumMember(Value = "SY_DID")]
            SyDid,
            
            /// <summary>
            /// Enum SzDid for "SZ_DID"
            /// </summary>
            [EnumMember(Value = "SZ_DID")]
            SzDid,
            
            /// <summary>
            /// Enum TdDid for "TD_DID"
            /// </summary>
            [EnumMember(Value = "TD_DID")]
            TdDid,
            
            /// <summary>
            /// Enum TgDid for "TG_DID"
            /// </summary>
            [EnumMember(Value = "TG_DID")]
            TgDid,
            
            /// <summary>
            /// Enum TjDid for "TJ_DID"
            /// </summary>
            [EnumMember(Value = "TJ_DID")]
            TjDid,
            
            /// <summary>
            /// Enum TkDid for "TK_DID"
            /// </summary>
            [EnumMember(Value = "TK_DID")]
            TkDid,
            
            /// <summary>
            /// Enum TlDid for "TL_DID"
            /// </summary>
            [EnumMember(Value = "TL_DID")]
            TlDid,
            
            /// <summary>
            /// Enum TmDid for "TM_DID"
            /// </summary>
            [EnumMember(Value = "TM_DID")]
            TmDid,
            
            /// <summary>
            /// Enum TnDid for "TN_DID"
            /// </summary>
            [EnumMember(Value = "TN_DID")]
            TnDid,
            
            /// <summary>
            /// Enum ToDid for "TO_DID"
            /// </summary>
            [EnumMember(Value = "TO_DID")]
            ToDid,
            
            /// <summary>
            /// Enum TvDid for "TV_DID"
            /// </summary>
            [EnumMember(Value = "TV_DID")]
            TvDid,
            
            /// <summary>
            /// Enum TwDid for "TW_DID"
            /// </summary>
            [EnumMember(Value = "TW_DID")]
            TwDid,
            
            /// <summary>
            /// Enum TzDid for "TZ_DID"
            /// </summary>
            [EnumMember(Value = "TZ_DID")]
            TzDid,
            
            /// <summary>
            /// Enum UaDid for "UA_DID"
            /// </summary>
            [EnumMember(Value = "UA_DID")]
            UaDid,
            
            /// <summary>
            /// Enum UgDid for "UG_DID"
            /// </summary>
            [EnumMember(Value = "UG_DID")]
            UgDid,
            
            /// <summary>
            /// Enum UyDid for "UY_DID"
            /// </summary>
            [EnumMember(Value = "UY_DID")]
            UyDid,
            
            /// <summary>
            /// Enum UzDid for "UZ_DID"
            /// </summary>
            [EnumMember(Value = "UZ_DID")]
            UzDid,
            
            /// <summary>
            /// Enum VuDid for "VU_DID"
            /// </summary>
            [EnumMember(Value = "VU_DID")]
            VuDid,
            
            /// <summary>
            /// Enum WfDid for "WF_DID"
            /// </summary>
            [EnumMember(Value = "WF_DID")]
            WfDid,
            
            /// <summary>
            /// Enum WsDid for "WS_DID"
            /// </summary>
            [EnumMember(Value = "WS_DID")]
            WsDid,
            
            /// <summary>
            /// Enum XgDid for "XG_DID"
            /// </summary>
            [EnumMember(Value = "XG_DID")]
            XgDid,
            
            /// <summary>
            /// Enum XnDid for "XN_DID"
            /// </summary>
            [EnumMember(Value = "XN_DID")]
            XnDid,
            
            /// <summary>
            /// Enum Xv882Did for "XV_882_DID"
            /// </summary>
            [EnumMember(Value = "XV_882_DID")]
            Xv882Did,
            
            /// <summary>
            /// Enum Xv883Did for "XV_883_DID"
            /// </summary>
            [EnumMember(Value = "XV_883_DID")]
            Xv883Did,
            
            /// <summary>
            /// Enum YeDid for "YE_DID"
            /// </summary>
            [EnumMember(Value = "YE_DID")]
            YeDid,
            
            /// <summary>
            /// Enum YtDid for "YT_DID"
            /// </summary>
            [EnumMember(Value = "YT_DID")]
            YtDid,
            
            /// <summary>
            /// Enum ZmDid for "ZM_DID"
            /// </summary>
            [EnumMember(Value = "ZM_DID")]
            ZmDid,
            
            /// <summary>
            /// Enum ZwDid for "ZW_DID"
            /// </summary>
            [EnumMember(Value = "ZW_DID")]
            ZwDid,
            
            /// <summary>
            /// Enum SxDid for "SX_DID"
            /// </summary>
            [EnumMember(Value = "SX_DID")]
            SxDid
        }

        /// <summary>
        /// Current status of this DID order
        /// </summary>
        /// <value>Current status of this DID order</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Class of DID being purchased (eg. us-domestic, toll-free, etc)
        /// </summary>
        /// <value>Class of DID being purchased (eg. us-domestic, toll-free, etc)</value>
        [DataMember(Name="phoneNumberType", EmitDefaultValue=false)]
        public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberOrder" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Did">DID purchased.</param>
        /// <param name="EffectiveStartDate">Effective date of service for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EffectiveEndDate">Effective disconnection date for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="LastUpdated">Date of last update. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="StartAuthUserId">UserId authorizing purchase.</param>
        /// <param name="EndAuthUserId">UserId authorizing disconnection.</param>
        /// <param name="Status">Current status of this DID order.</param>
        /// <param name="PhoneNumberType">Class of DID being purchased (eg. us-domestic, toll-free, etc).</param>
        /// <param name="Porting">Whether or not the number was ported (default to false).</param>
        /// <param name="BillingAddress">Billing address used for a number port.</param>
        /// <param name="ResponsibleContact">Company contact for a number port.</param>
        /// <param name="CompanyName">Company name for a number port.</param>
        /// <param name="CountryCode">Country dial in codes (telephone dialing prefixes).</param>
        /// <param name="EnvelopeId">Id of the terms and conditions envelope for the order..</param>
        public NumberOrder(string Name = null, string Did = null, DateTime? EffectiveStartDate = null, DateTime? EffectiveEndDate = null, DateTime? LastUpdated = null, string StartAuthUserId = null, string EndAuthUserId = null, StatusEnum? Status = null, PhoneNumberTypeEnum? PhoneNumberType = null, bool? Porting = null, PortBillingAddress BillingAddress = null, PortContact ResponsibleContact = null, string CompanyName = null, string CountryCode = null, string EnvelopeId = null)
        {
            this.Name = Name;
            this.Did = Did;
            this.EffectiveStartDate = EffectiveStartDate;
            this.EffectiveEndDate = EffectiveEndDate;
            this.LastUpdated = LastUpdated;
            this.StartAuthUserId = StartAuthUserId;
            this.EndAuthUserId = EndAuthUserId;
            this.Status = Status;
            this.PhoneNumberType = PhoneNumberType;
            // use default value if no "Porting" provided
            if (Porting == null)
            {
                this.Porting = false;
            }
            else
            {
                this.Porting = Porting;
            }
            this.BillingAddress = BillingAddress;
            this.ResponsibleContact = ResponsibleContact;
            this.CompanyName = CompanyName;
            this.CountryCode = CountryCode;
            this.EnvelopeId = EnvelopeId;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// DID purchased
        /// </summary>
        /// <value>DID purchased</value>
        [DataMember(Name="did", EmitDefaultValue=false)]
        public string Did { get; set; }
        /// <summary>
        /// Effective date of service for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Effective date of service for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="effectiveStartDate", EmitDefaultValue=false)]
        public DateTime? EffectiveStartDate { get; set; }
        /// <summary>
        /// Effective disconnection date for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Effective disconnection date for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
        public DateTime? EffectiveEndDate { get; set; }
        /// <summary>
        /// Date of last update. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date of last update. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
        public DateTime? LastUpdated { get; set; }
        /// <summary>
        /// UserId authorizing purchase
        /// </summary>
        /// <value>UserId authorizing purchase</value>
        [DataMember(Name="startAuthUserId", EmitDefaultValue=false)]
        public string StartAuthUserId { get; set; }
        /// <summary>
        /// UserId authorizing disconnection
        /// </summary>
        /// <value>UserId authorizing disconnection</value>
        [DataMember(Name="endAuthUserId", EmitDefaultValue=false)]
        public string EndAuthUserId { get; set; }
        /// <summary>
        /// Whether or not the number was ported
        /// </summary>
        /// <value>Whether or not the number was ported</value>
        [DataMember(Name="porting", EmitDefaultValue=false)]
        public bool? Porting { get; set; }
        /// <summary>
        /// Billing address used for a number port
        /// </summary>
        /// <value>Billing address used for a number port</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public PortBillingAddress BillingAddress { get; set; }
        /// <summary>
        /// Company contact for a number port
        /// </summary>
        /// <value>Company contact for a number port</value>
        [DataMember(Name="responsibleContact", EmitDefaultValue=false)]
        public PortContact ResponsibleContact { get; set; }
        /// <summary>
        /// Company name for a number port
        /// </summary>
        /// <value>Company name for a number port</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// Country dial in codes (telephone dialing prefixes)
        /// </summary>
        /// <value>Country dial in codes (telephone dialing prefixes)</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Id of the terms and conditions envelope for the order.
        /// </summary>
        /// <value>Id of the terms and conditions envelope for the order.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  StartAuthUserId: ").Append(StartAuthUserId).Append("\n");
            sb.Append("  EndAuthUserId: ").Append(EndAuthUserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
            sb.Append("  Porting: ").Append(Porting).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ResponsibleContact: ").Append(ResponsibleContact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as NumberOrder);
        }

        /// <summary>
        /// Returns true if NumberOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of NumberOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Did == other.Did ||
                    this.Did != null &&
                    this.Did.Equals(other.Did)
                ) &&
                (
                    this.EffectiveStartDate == other.EffectiveStartDate ||
                    this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(other.EffectiveStartDate)
                ) &&
                (
                    this.EffectiveEndDate == other.EffectiveEndDate ||
                    this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(other.EffectiveEndDate)
                ) &&
                (
                    this.LastUpdated == other.LastUpdated ||
                    this.LastUpdated != null &&
                    this.LastUpdated.Equals(other.LastUpdated)
                ) &&
                (
                    this.StartAuthUserId == other.StartAuthUserId ||
                    this.StartAuthUserId != null &&
                    this.StartAuthUserId.Equals(other.StartAuthUserId)
                ) &&
                (
                    this.EndAuthUserId == other.EndAuthUserId ||
                    this.EndAuthUserId != null &&
                    this.EndAuthUserId.Equals(other.EndAuthUserId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.PhoneNumberType == other.PhoneNumberType ||
                    this.PhoneNumberType != null &&
                    this.PhoneNumberType.Equals(other.PhoneNumberType)
                ) &&
                (
                    this.Porting == other.Porting ||
                    this.Porting != null &&
                    this.Porting.Equals(other.Porting)
                ) &&
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) &&
                (
                    this.ResponsibleContact == other.ResponsibleContact ||
                    this.ResponsibleContact != null &&
                    this.ResponsibleContact.Equals(other.ResponsibleContact)
                ) &&
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Did != null)
                    hash = hash * 59 + this.Did.GetHashCode();
                if (this.EffectiveStartDate != null)
                    hash = hash * 59 + this.EffectiveStartDate.GetHashCode();
                if (this.EffectiveEndDate != null)
                    hash = hash * 59 + this.EffectiveEndDate.GetHashCode();
                if (this.LastUpdated != null)
                    hash = hash * 59 + this.LastUpdated.GetHashCode();
                if (this.StartAuthUserId != null)
                    hash = hash * 59 + this.StartAuthUserId.GetHashCode();
                if (this.EndAuthUserId != null)
                    hash = hash * 59 + this.EndAuthUserId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.PhoneNumberType != null)
                    hash = hash * 59 + this.PhoneNumberType.GetHashCode();
                if (this.Porting != null)
                    hash = hash * 59 + this.Porting.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.ResponsibleContact != null)
                    hash = hash * 59 + this.ResponsibleContact.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatfield.EnviroData.Core
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ODM2Entities : DbContext
    {
        public ODM2Entities()
            : base("name=ODM2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionAnnotation> ActionAnnotations { get; set; }
        public virtual DbSet<ActionBy> ActionBies { get; set; }
        public virtual DbSet<ActionDirective> ActionDirectives { get; set; }
        public virtual DbSet<ActionExtensionPropertyValue> ActionExtensionPropertyValues { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Affiliation> Affiliations { get; set; }
        public virtual DbSet<Annotation> Annotations { get; set; }
        public virtual DbSet<AuthorList> AuthorLists { get; set; }
        public virtual DbSet<CalibrationAction> CalibrationActions { get; set; }
        public virtual DbSet<CalibrationReferenceEquipment> CalibrationReferenceEquipments { get; set; }
        public virtual DbSet<CalibrationStandard> CalibrationStandards { get; set; }
        public virtual DbSet<CategoricalResult> CategoricalResults { get; set; }
        public virtual DbSet<CategoricalResultValueAnnotation> CategoricalResultValueAnnotations { get; set; }
        public virtual DbSet<CategoricalResultValue> CategoricalResultValues { get; set; }
        public virtual DbSet<CitationExtensionPropertyValue> CitationExtensionPropertyValues { get; set; }
        public virtual DbSet<CitationExternalIdentifier> CitationExternalIdentifiers { get; set; }
        public virtual DbSet<Citation> Citations { get; set; }
        public virtual DbSet<CV_ActionType> CV_ActionType { get; set; }
        public virtual DbSet<CV_AggregationStatistic> CV_AggregationStatistic { get; set; }
        public virtual DbSet<CV_AnnotationType> CV_AnnotationType { get; set; }
        public virtual DbSet<CV_CensorCode> CV_CensorCode { get; set; }
        public virtual DbSet<CV_DataQualityType> CV_DataQualityType { get; set; }
        public virtual DbSet<CV_DatasetTypeCV> CV_DatasetTypeCV { get; set; }
        public virtual DbSet<CV_DirectiveType> CV_DirectiveType { get; set; }
        public virtual DbSet<CV_ElevationDatum> CV_ElevationDatum { get; set; }
        public virtual DbSet<CV_EquipmentType> CV_EquipmentType { get; set; }
        public virtual DbSet<CV_MethodType> CV_MethodType { get; set; }
        public virtual DbSet<CV_OrganizationType> CV_OrganizationType { get; set; }
        public virtual DbSet<CV_PropertyDataType> CV_PropertyDataType { get; set; }
        public virtual DbSet<CV_QualityCode> CV_QualityCode { get; set; }
        public virtual DbSet<CV_ReferenceMaterialMedium> CV_ReferenceMaterialMedium { get; set; }
        public virtual DbSet<CV_RelationshipType> CV_RelationshipType { get; set; }
        public virtual DbSet<CV_ResultType> CV_ResultType { get; set; }
        public virtual DbSet<CV_SampledMedium> CV_SampledMedium { get; set; }
        public virtual DbSet<CV_SamplingFeatureGeoType> CV_SamplingFeatureGeoType { get; set; }
        public virtual DbSet<CV_SamplingFeatureType> CV_SamplingFeatureType { get; set; }
        public virtual DbSet<CV_SiteType> CV_SiteType { get; set; }
        public virtual DbSet<CV_SpatialOffsetType> CV_SpatialOffsetType { get; set; }
        public virtual DbSet<CV_Speciation> CV_Speciation { get; set; }
        public virtual DbSet<CV_SpecimenMedium> CV_SpecimenMedium { get; set; }
        public virtual DbSet<CV_SpecimenType> CV_SpecimenType { get; set; }
        public virtual DbSet<CV_Status> CV_Status { get; set; }
        public virtual DbSet<CV_TaxonomicClassifierType> CV_TaxonomicClassifierType { get; set; }
        public virtual DbSet<CV_UnitsType> CV_UnitsType { get; set; }
        public virtual DbSet<CV_VariableName> CV_VariableName { get; set; }
        public virtual DbSet<CV_VariableType> CV_VariableType { get; set; }
        public virtual DbSet<DataloggerFileColumn> DataloggerFileColumns { get; set; }
        public virtual DbSet<DataLoggerFile> DataLoggerFiles { get; set; }
        public virtual DbSet<DataloggerProgramFile> DataloggerProgramFiles { get; set; }
        public virtual DbSet<DataQuality> DataQualities { get; set; }
        public virtual DbSet<DatasetCitation> DatasetCitations { get; set; }
        public virtual DbSet<Dataset> Datasets { get; set; }
        public virtual DbSet<DatasetsResult> DatasetsResults { get; set; }
        public virtual DbSet<DerivationEquation> DerivationEquations { get; set; }
        public virtual DbSet<Directive> Directives { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<EquipmentAnnotation> EquipmentAnnotations { get; set; }
        public virtual DbSet<EquipmentModel> EquipmentModels { get; set; }
        public virtual DbSet<EquipmentUsed> EquipmentUseds { get; set; }
        public virtual DbSet<ExtensionProperty> ExtensionProperties { get; set; }
        public virtual DbSet<ExternalIdentifierSystem> ExternalIdentifierSystems { get; set; }
        public virtual DbSet<FeatureAction> FeatureActions { get; set; }
        public virtual DbSet<InstrumentOutputVariable> InstrumentOutputVariables { get; set; }
        public virtual DbSet<MaintenanceAction> MaintenanceActions { get; set; }
        public virtual DbSet<MeasurementResult> MeasurementResults { get; set; }
        public virtual DbSet<MeasurementResultValueAnnotation> MeasurementResultValueAnnotations { get; set; }
        public virtual DbSet<MeasurementResultValue> MeasurementResultValues { get; set; }
        public virtual DbSet<MethodAnnotation> MethodAnnotations { get; set; }
        public virtual DbSet<MethodCitation> MethodCitations { get; set; }
        public virtual DbSet<MethodExtensionPropertyValue> MethodExtensionPropertyValues { get; set; }
        public virtual DbSet<MethodExternalIdentifier> MethodExternalIdentifiers { get; set; }
        public virtual DbSet<Method> Methods { get; set; }
        public virtual DbSet<ModelAffiliation> ModelAffiliations { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonExternalIdentifier> PersonExternalIdentifiers { get; set; }
        public virtual DbSet<PointCoverageResult> PointCoverageResults { get; set; }
        public virtual DbSet<PointCoverageResultValueAnnotation> PointCoverageResultValueAnnotations { get; set; }
        public virtual DbSet<PointCoverageResultValue> PointCoverageResultValues { get; set; }
        public virtual DbSet<ProcessingLevel> ProcessingLevels { get; set; }
        public virtual DbSet<ProfileResult> ProfileResults { get; set; }
        public virtual DbSet<ProfileResultValueAnnotation> ProfileResultValueAnnotations { get; set; }
        public virtual DbSet<ProfileResultValue> ProfileResultValues { get; set; }
        public virtual DbSet<ReferenceMaterialExternalIdentifier> ReferenceMaterialExternalIdentifiers { get; set; }
        public virtual DbSet<ReferenceMaterial> ReferenceMaterials { get; set; }
        public virtual DbSet<ReferenceMaterialValue> ReferenceMaterialValues { get; set; }
        public virtual DbSet<RelatedAction> RelatedActions { get; set; }
        public virtual DbSet<RelatedAnnotation> RelatedAnnotations { get; set; }
        public virtual DbSet<RelatedCitation> RelatedCitations { get; set; }
        public virtual DbSet<RelatedDataset> RelatedDatasets { get; set; }
        public virtual DbSet<RelatedEquipment> RelatedEquipments { get; set; }
        public virtual DbSet<RelatedFeature> RelatedFeatures { get; set; }
        public virtual DbSet<RelatedModel> RelatedModels { get; set; }
        public virtual DbSet<RelatedResult> RelatedResults { get; set; }
        public virtual DbSet<ResultAnnotation> ResultAnnotations { get; set; }
        public virtual DbSet<ResultExtensionPropertyValue> ResultExtensionPropertyValues { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<ResultsDataQuality> ResultsDataQualities { get; set; }
        public virtual DbSet<SamplingFeatureAnnotation> SamplingFeatureAnnotations { get; set; }
        public virtual DbSet<SamplingFeatureExtensionPropertyValue> SamplingFeatureExtensionPropertyValues { get; set; }
        public virtual DbSet<SamplingFeatureExternalIdentifier> SamplingFeatureExternalIdentifiers { get; set; }
        public virtual DbSet<SamplingFeature> SamplingFeatures { get; set; }
        public virtual DbSet<SectionResult> SectionResults { get; set; }
        public virtual DbSet<SectionResultValueAnnotation> SectionResultValueAnnotations { get; set; }
        public virtual DbSet<SectionResultValue> SectionResultValues { get; set; }
        public virtual DbSet<Simulation> Simulations { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SpatialOffset> SpatialOffsets { get; set; }
        public virtual DbSet<SpatialReferenceExternalIdentifier> SpatialReferenceExternalIdentifiers { get; set; }
        public virtual DbSet<SpatialReference> SpatialReferences { get; set; }
        public virtual DbSet<SpecimenBatchPostion> SpecimenBatchPostions { get; set; }
        public virtual DbSet<Specimen> Specimens { get; set; }
        public virtual DbSet<SpecimenTaxonomicClassifier> SpecimenTaxonomicClassifiers { get; set; }
        public virtual DbSet<SpectraResult> SpectraResults { get; set; }
        public virtual DbSet<SpectraResultValueAnnotation> SpectraResultValueAnnotations { get; set; }
        public virtual DbSet<SpectraResultValue> SpectraResultValues { get; set; }
        public virtual DbSet<TaxonomicClassifierExternalIdentifier> TaxonomicClassifierExternalIdentifiers { get; set; }
        public virtual DbSet<TaxonomicClassifier> TaxonomicClassifiers { get; set; }
        public virtual DbSet<TimeSeriesResult> TimeSeriesResults { get; set; }
        public virtual DbSet<TimeSeriesResultValueAnnotation> TimeSeriesResultValueAnnotations { get; set; }
        public virtual DbSet<TimeSeriesResultValue> TimeSeriesResultValues { get; set; }
        public virtual DbSet<TrajectoryResult> TrajectoryResults { get; set; }
        public virtual DbSet<TrajectoryResultValueAnnotation> TrajectoryResultValueAnnotations { get; set; }
        public virtual DbSet<TrajectoryResultValue> TrajectoryResultValues { get; set; }
        public virtual DbSet<TransectResult> TransectResults { get; set; }
        public virtual DbSet<TransectResultValueAnnotation> TransectResultValueAnnotations { get; set; }
        public virtual DbSet<TransectResultValue> TransectResultValues { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<VariableExtensionPropertyValue> VariableExtensionPropertyValues { get; set; }
        public virtual DbSet<VariableExternalIdentifier> VariableExternalIdentifiers { get; set; }
        public virtual DbSet<Variable> Variables { get; set; }
        public virtual DbSet<FieldWorkPlan> FieldWorkPlans { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
    }
}

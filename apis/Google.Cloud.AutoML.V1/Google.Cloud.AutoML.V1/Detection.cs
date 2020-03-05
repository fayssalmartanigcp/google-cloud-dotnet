// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/detection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/detection.proto</summary>
  public static partial class DetectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/detection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DetectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvY2xvdWQvYXV0b21sL3YxL2RldGVjdGlvbi5wcm90bxIWZ29v",
            "Z2xlLmNsb3VkLmF1dG9tbC52MRolZ29vZ2xlL2Nsb3VkL2F1dG9tbC92MS9n",
            "ZW9tZXRyeS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnByb3Rv",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvImsKHkltYWdlT2JqZWN0",
            "RGV0ZWN0aW9uQW5ub3RhdGlvbhI6Cgxib3VuZGluZ19ib3gYASABKAsyJC5n",
            "b29nbGUuY2xvdWQuYXV0b21sLnYxLkJvdW5kaW5nUG9seRINCgVzY29yZRgC",
            "IAEoAiKpAgoXQm91bmRpbmdCb3hNZXRyaWNzRW50cnkSFQoNaW91X3RocmVz",
            "aG9sZBgBIAEoAhIeChZtZWFuX2F2ZXJhZ2VfcHJlY2lzaW9uGAIgASgCEmoK",
            "GmNvbmZpZGVuY2VfbWV0cmljc19lbnRyaWVzGAMgAygLMkYuZ29vZ2xlLmNs",
            "b3VkLmF1dG9tbC52MS5Cb3VuZGluZ0JveE1ldHJpY3NFbnRyeS5Db25maWRl",
            "bmNlTWV0cmljc0VudHJ5GmsKFkNvbmZpZGVuY2VNZXRyaWNzRW50cnkSHAoU",
            "Y29uZmlkZW5jZV90aHJlc2hvbGQYASABKAISDgoGcmVjYWxsGAIgASgCEhEK",
            "CXByZWNpc2lvbhgDIAEoAhIQCghmMV9zY29yZRgEIAEoAiLRAQolSW1hZ2VP",
            "YmplY3REZXRlY3Rpb25FdmFsdWF0aW9uTWV0cmljcxIkChxldmFsdWF0ZWRf",
            "Ym91bmRpbmdfYm94X2NvdW50GAEgASgFElUKHGJvdW5kaW5nX2JveF9tZXRy",
            "aWNzX2VudHJpZXMYAiADKAsyLy5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkJv",
            "dW5kaW5nQm94TWV0cmljc0VudHJ5EisKI2JvdW5kaW5nX2JveF9tZWFuX2F2",
            "ZXJhZ2VfcHJlY2lzaW9uGAMgASgCQqoBChpjb20uZ29vZ2xlLmNsb3VkLmF1",
            "dG9tbC52MVABWjxnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Nsb3VkL2F1dG9tbC92MTthdXRvbWyqAhZHb29nbGUuQ2xvdWQuQXV0",
            "b01MLlYxygIWR29vZ2xlXENsb3VkXEF1dG9NbFxWMeoCGUdvb2dsZTo6Q2xv",
            "dWQ6OkF1dG9NTDo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.AutoML.V1.GeometryReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation), global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation.Parser, new[]{ "BoundingBox", "Score" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry), global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Parser, new[]{ "IouThreshold", "MeanAveragePrecision", "ConfidenceMetricsEntries" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry), global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry.Parser, new[]{ "ConfidenceThreshold", "Recall", "Precision", "F1Score" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics), global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics.Parser, new[]{ "EvaluatedBoundingBoxCount", "BoundingBoxMetricsEntries", "BoundingBoxMeanAveragePrecision" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Annotation details for image object detection.
  /// </summary>
  public sealed partial class ImageObjectDetectionAnnotation : pb::IMessage<ImageObjectDetectionAnnotation> {
    private static readonly pb::MessageParser<ImageObjectDetectionAnnotation> _parser = new pb::MessageParser<ImageObjectDetectionAnnotation>(() => new ImageObjectDetectionAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageObjectDetectionAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.DetectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionAnnotation(ImageObjectDetectionAnnotation other) : this() {
      boundingBox_ = other.boundingBox_ != null ? other.boundingBox_.Clone() : null;
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionAnnotation Clone() {
      return new ImageObjectDetectionAnnotation(this);
    }

    /// <summary>Field number for the "bounding_box" field.</summary>
    public const int BoundingBoxFieldNumber = 1;
    private global::Google.Cloud.AutoML.V1.BoundingPoly boundingBox_;
    /// <summary>
    /// Output only. The rectangle representing the object location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.BoundingPoly BoundingBox {
      get { return boundingBox_; }
      set {
        boundingBox_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 2;
    private float score_;
    /// <summary>
    /// Output only. The confidence that this annotation is positive for the parent example,
    /// value in [0, 1], higher means higher positivity confidence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageObjectDetectionAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImageObjectDetectionAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BoundingBox, other.BoundingBox)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Score, other.Score)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (boundingBox_ != null) hash ^= BoundingBox.GetHashCode();
      if (Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Score);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (boundingBox_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BoundingBox);
      }
      if (Score != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Score);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (boundingBox_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoundingBox);
      }
      if (Score != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImageObjectDetectionAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.boundingBox_ != null) {
        if (boundingBox_ == null) {
          BoundingBox = new global::Google.Cloud.AutoML.V1.BoundingPoly();
        }
        BoundingBox.MergeFrom(other.BoundingBox);
      }
      if (other.Score != 0F) {
        Score = other.Score;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (boundingBox_ == null) {
              BoundingBox = new global::Google.Cloud.AutoML.V1.BoundingPoly();
            }
            input.ReadMessage(BoundingBox);
            break;
          }
          case 21: {
            Score = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Bounding box matching model metrics for a single intersection-over-union
  /// threshold and multiple label match confidence thresholds.
  /// </summary>
  public sealed partial class BoundingBoxMetricsEntry : pb::IMessage<BoundingBoxMetricsEntry> {
    private static readonly pb::MessageParser<BoundingBoxMetricsEntry> _parser = new pb::MessageParser<BoundingBoxMetricsEntry>(() => new BoundingBoxMetricsEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoundingBoxMetricsEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.DetectionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundingBoxMetricsEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundingBoxMetricsEntry(BoundingBoxMetricsEntry other) : this() {
      iouThreshold_ = other.iouThreshold_;
      meanAveragePrecision_ = other.meanAveragePrecision_;
      confidenceMetricsEntries_ = other.confidenceMetricsEntries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundingBoxMetricsEntry Clone() {
      return new BoundingBoxMetricsEntry(this);
    }

    /// <summary>Field number for the "iou_threshold" field.</summary>
    public const int IouThresholdFieldNumber = 1;
    private float iouThreshold_;
    /// <summary>
    /// Output only. The intersection-over-union threshold value used to compute
    /// this metrics entry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float IouThreshold {
      get { return iouThreshold_; }
      set {
        iouThreshold_ = value;
      }
    }

    /// <summary>Field number for the "mean_average_precision" field.</summary>
    public const int MeanAveragePrecisionFieldNumber = 2;
    private float meanAveragePrecision_;
    /// <summary>
    /// Output only. The mean average precision, most often close to au_prc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float MeanAveragePrecision {
      get { return meanAveragePrecision_; }
      set {
        meanAveragePrecision_ = value;
      }
    }

    /// <summary>Field number for the "confidence_metrics_entries" field.</summary>
    public const int ConfidenceMetricsEntriesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry> _repeated_confidenceMetricsEntries_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry> confidenceMetricsEntries_ = new pbc::RepeatedField<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry>();
    /// <summary>
    /// Output only. Metrics for each label-match confidence_threshold from
    /// 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99. Precision-recall curve is
    /// derived from them.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Types.ConfidenceMetricsEntry> ConfidenceMetricsEntries {
      get { return confidenceMetricsEntries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoundingBoxMetricsEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoundingBoxMetricsEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IouThreshold, other.IouThreshold)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeanAveragePrecision, other.MeanAveragePrecision)) return false;
      if(!confidenceMetricsEntries_.Equals(other.confidenceMetricsEntries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IouThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IouThreshold);
      if (MeanAveragePrecision != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeanAveragePrecision);
      hash ^= confidenceMetricsEntries_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IouThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(IouThreshold);
      }
      if (MeanAveragePrecision != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(MeanAveragePrecision);
      }
      confidenceMetricsEntries_.WriteTo(output, _repeated_confidenceMetricsEntries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IouThreshold != 0F) {
        size += 1 + 4;
      }
      if (MeanAveragePrecision != 0F) {
        size += 1 + 4;
      }
      size += confidenceMetricsEntries_.CalculateSize(_repeated_confidenceMetricsEntries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoundingBoxMetricsEntry other) {
      if (other == null) {
        return;
      }
      if (other.IouThreshold != 0F) {
        IouThreshold = other.IouThreshold;
      }
      if (other.MeanAveragePrecision != 0F) {
        MeanAveragePrecision = other.MeanAveragePrecision;
      }
      confidenceMetricsEntries_.Add(other.confidenceMetricsEntries_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            IouThreshold = input.ReadFloat();
            break;
          }
          case 21: {
            MeanAveragePrecision = input.ReadFloat();
            break;
          }
          case 26: {
            confidenceMetricsEntries_.AddEntriesFrom(input, _repeated_confidenceMetricsEntries_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BoundingBoxMetricsEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Metrics for a single confidence threshold.
      /// </summary>
      public sealed partial class ConfidenceMetricsEntry : pb::IMessage<ConfidenceMetricsEntry> {
        private static readonly pb::MessageParser<ConfidenceMetricsEntry> _parser = new pb::MessageParser<ConfidenceMetricsEntry>(() => new ConfidenceMetricsEntry());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ConfidenceMetricsEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ConfidenceMetricsEntry() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ConfidenceMetricsEntry(ConfidenceMetricsEntry other) : this() {
          confidenceThreshold_ = other.confidenceThreshold_;
          recall_ = other.recall_;
          precision_ = other.precision_;
          f1Score_ = other.f1Score_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ConfidenceMetricsEntry Clone() {
          return new ConfidenceMetricsEntry(this);
        }

        /// <summary>Field number for the "confidence_threshold" field.</summary>
        public const int ConfidenceThresholdFieldNumber = 1;
        private float confidenceThreshold_;
        /// <summary>
        /// Output only. The confidence threshold value used to compute the metrics.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float ConfidenceThreshold {
          get { return confidenceThreshold_; }
          set {
            confidenceThreshold_ = value;
          }
        }

        /// <summary>Field number for the "recall" field.</summary>
        public const int RecallFieldNumber = 2;
        private float recall_;
        /// <summary>
        /// Output only. Recall under the given confidence threshold.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float Recall {
          get { return recall_; }
          set {
            recall_ = value;
          }
        }

        /// <summary>Field number for the "precision" field.</summary>
        public const int PrecisionFieldNumber = 3;
        private float precision_;
        /// <summary>
        /// Output only. Precision under the given confidence threshold.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float Precision {
          get { return precision_; }
          set {
            precision_ = value;
          }
        }

        /// <summary>Field number for the "f1_score" field.</summary>
        public const int F1ScoreFieldNumber = 4;
        private float f1Score_;
        /// <summary>
        /// Output only. The harmonic mean of recall and precision.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float F1Score {
          get { return f1Score_; }
          set {
            f1Score_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ConfidenceMetricsEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ConfidenceMetricsEntry other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConfidenceThreshold, other.ConfidenceThreshold)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Recall, other.Recall)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Precision, other.Precision)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(F1Score, other.F1Score)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ConfidenceThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConfidenceThreshold);
          if (Recall != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Recall);
          if (Precision != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Precision);
          if (F1Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(F1Score);
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (ConfidenceThreshold != 0F) {
            output.WriteRawTag(13);
            output.WriteFloat(ConfidenceThreshold);
          }
          if (Recall != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(Recall);
          }
          if (Precision != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(Precision);
          }
          if (F1Score != 0F) {
            output.WriteRawTag(37);
            output.WriteFloat(F1Score);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ConfidenceThreshold != 0F) {
            size += 1 + 4;
          }
          if (Recall != 0F) {
            size += 1 + 4;
          }
          if (Precision != 0F) {
            size += 1 + 4;
          }
          if (F1Score != 0F) {
            size += 1 + 4;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ConfidenceMetricsEntry other) {
          if (other == null) {
            return;
          }
          if (other.ConfidenceThreshold != 0F) {
            ConfidenceThreshold = other.ConfidenceThreshold;
          }
          if (other.Recall != 0F) {
            Recall = other.Recall;
          }
          if (other.Precision != 0F) {
            Precision = other.Precision;
          }
          if (other.F1Score != 0F) {
            F1Score = other.F1Score;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 13: {
                ConfidenceThreshold = input.ReadFloat();
                break;
              }
              case 21: {
                Recall = input.ReadFloat();
                break;
              }
              case 29: {
                Precision = input.ReadFloat();
                break;
              }
              case 37: {
                F1Score = input.ReadFloat();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Model evaluation metrics for image object detection problems.
  /// Evaluates prediction quality of labeled bounding boxes.
  /// </summary>
  public sealed partial class ImageObjectDetectionEvaluationMetrics : pb::IMessage<ImageObjectDetectionEvaluationMetrics> {
    private static readonly pb::MessageParser<ImageObjectDetectionEvaluationMetrics> _parser = new pb::MessageParser<ImageObjectDetectionEvaluationMetrics>(() => new ImageObjectDetectionEvaluationMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageObjectDetectionEvaluationMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.DetectionReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionEvaluationMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionEvaluationMetrics(ImageObjectDetectionEvaluationMetrics other) : this() {
      evaluatedBoundingBoxCount_ = other.evaluatedBoundingBoxCount_;
      boundingBoxMetricsEntries_ = other.boundingBoxMetricsEntries_.Clone();
      boundingBoxMeanAveragePrecision_ = other.boundingBoxMeanAveragePrecision_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionEvaluationMetrics Clone() {
      return new ImageObjectDetectionEvaluationMetrics(this);
    }

    /// <summary>Field number for the "evaluated_bounding_box_count" field.</summary>
    public const int EvaluatedBoundingBoxCountFieldNumber = 1;
    private int evaluatedBoundingBoxCount_;
    /// <summary>
    /// Output only. The total number of bounding boxes (i.e. summed over all
    /// images) the ground truth used to create this evaluation had.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EvaluatedBoundingBoxCount {
      get { return evaluatedBoundingBoxCount_; }
      set {
        evaluatedBoundingBoxCount_ = value;
      }
    }

    /// <summary>Field number for the "bounding_box_metrics_entries" field.</summary>
    public const int BoundingBoxMetricsEntriesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry> _repeated_boundingBoxMetricsEntries_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry> boundingBoxMetricsEntries_ = new pbc::RepeatedField<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry>();
    /// <summary>
    /// Output only. The bounding boxes match metrics for each
    /// Intersection-over-union threshold 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99
    /// and each label confidence threshold 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99
    /// pair.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.AutoML.V1.BoundingBoxMetricsEntry> BoundingBoxMetricsEntries {
      get { return boundingBoxMetricsEntries_; }
    }

    /// <summary>Field number for the "bounding_box_mean_average_precision" field.</summary>
    public const int BoundingBoxMeanAveragePrecisionFieldNumber = 3;
    private float boundingBoxMeanAveragePrecision_;
    /// <summary>
    /// Output only. The single metric for bounding boxes evaluation:
    /// the mean_average_precision averaged over all bounding_box_metrics_entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BoundingBoxMeanAveragePrecision {
      get { return boundingBoxMeanAveragePrecision_; }
      set {
        boundingBoxMeanAveragePrecision_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageObjectDetectionEvaluationMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImageObjectDetectionEvaluationMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EvaluatedBoundingBoxCount != other.EvaluatedBoundingBoxCount) return false;
      if(!boundingBoxMetricsEntries_.Equals(other.boundingBoxMetricsEntries_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BoundingBoxMeanAveragePrecision, other.BoundingBoxMeanAveragePrecision)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EvaluatedBoundingBoxCount != 0) hash ^= EvaluatedBoundingBoxCount.GetHashCode();
      hash ^= boundingBoxMetricsEntries_.GetHashCode();
      if (BoundingBoxMeanAveragePrecision != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BoundingBoxMeanAveragePrecision);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EvaluatedBoundingBoxCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EvaluatedBoundingBoxCount);
      }
      boundingBoxMetricsEntries_.WriteTo(output, _repeated_boundingBoxMetricsEntries_codec);
      if (BoundingBoxMeanAveragePrecision != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(BoundingBoxMeanAveragePrecision);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EvaluatedBoundingBoxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvaluatedBoundingBoxCount);
      }
      size += boundingBoxMetricsEntries_.CalculateSize(_repeated_boundingBoxMetricsEntries_codec);
      if (BoundingBoxMeanAveragePrecision != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImageObjectDetectionEvaluationMetrics other) {
      if (other == null) {
        return;
      }
      if (other.EvaluatedBoundingBoxCount != 0) {
        EvaluatedBoundingBoxCount = other.EvaluatedBoundingBoxCount;
      }
      boundingBoxMetricsEntries_.Add(other.boundingBoxMetricsEntries_);
      if (other.BoundingBoxMeanAveragePrecision != 0F) {
        BoundingBoxMeanAveragePrecision = other.BoundingBoxMeanAveragePrecision;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EvaluatedBoundingBoxCount = input.ReadInt32();
            break;
          }
          case 18: {
            boundingBoxMetricsEntries_.AddEntriesFrom(input, _repeated_boundingBoxMetricsEntries_codec);
            break;
          }
          case 29: {
            BoundingBoxMeanAveragePrecision = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

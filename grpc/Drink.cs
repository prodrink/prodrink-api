// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: catalog/drink.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace prodrink.catalog {

  /// <summary>Holder for reflection information generated from catalog/drink.proto</summary>
  public static partial class DrinkReflection {

    #region Descriptor
    /// <summary>File descriptor for catalog/drink.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DrinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNjYXRhbG9nL2RyaW5rLnByb3RvEgdjYXRhbG9nIpYBCgVEcmluaxIKCgJp",
            "ZBgBIAEoBRIMCgRuYW1lGAIgASgJEiMKCGNhdGVnb3J5GAMgASgLMhEuY2F0",
            "YWxvZy5DYXRlZ29yeRIlCgpwcm9wZXJ0aWVzGAQgAygLMhEuY2F0YWxvZy5Q",
            "cm9wZXJ0eRISCgppbWFnZV91cmxzGAUgAygJEhMKC2Rlc2NyaXB0aW9uGAYg",
            "ASgJIn8KCENhdGVnb3J5EgoKAmlkGAEgASgFEgwKBG5hbWUYAiABKAkSKgoP",
            "cGFyZW50X2NhdGVnb3J5GAMgASgLMhEuY2F0YWxvZy5DYXRlZ29yeRItCg5w",
            "cm9wZXJ0eV90eXBlcxgEIAMoCzIVLmNhdGFsb2cuUHJvcGVydHlUeXBlIkoK",
            "DFByb3BlcnR5VHlwZRIKCgJpZBgBIAEoBRIMCgRuYW1lGAIgASgJEiAKBHR5",
            "cGUYAyABKA4yEi5jYXRhbG9nLlZhbHVlVHlwZSJSCghQcm9wZXJ0eRIKCgJp",
            "ZBgBIAEoBRIrCgxwcm9wZXJ0eVR5cGUYAiABKAsyFS5jYXRhbG9nLlByb3Bl",
            "cnR5VHlwZRINCgV2YWx1ZRgDIAEoCSpFCglWYWx1ZVR5cGUSCQoFSU5UMzIQ",
            "ABIJCgVJTlQ2NBABEgkKBUZMT0FUEAISCgoGU1RSSU5HEAMSCwoHQk9PTEVB",
            "ThAEQj0KGmlvLnByb2RyaW5rLmNhdGFsb2cuZG9tYWluQgpEcmlua091dGVy",
            "UAGqAhBwcm9kcmluay5jYXRhbG9nYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::prodrink.catalog.ValueType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.Drink), global::prodrink.catalog.Drink.Parser, new[]{ "Id", "Name", "Category", "Properties", "ImageUrls", "Description" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.Category), global::prodrink.catalog.Category.Parser, new[]{ "Id", "Name", "ParentCategory", "PropertyTypes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.PropertyType), global::prodrink.catalog.PropertyType.Parser, new[]{ "Id", "Name", "Type" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::prodrink.catalog.Property), global::prodrink.catalog.Property.Parser, new[]{ "Id", "PropertyType", "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ValueType {
    [pbr::OriginalName("INT32")] Int32 = 0,
    [pbr::OriginalName("INT64")] Int64 = 1,
    [pbr::OriginalName("FLOAT")] Float = 2,
    [pbr::OriginalName("STRING")] String = 3,
    [pbr::OriginalName("BOOLEAN")] Boolean = 4,
  }

  #endregion

  #region Messages
  public sealed partial class Drink : pb::IMessage<Drink> {
    private static readonly pb::MessageParser<Drink> _parser = new pb::MessageParser<Drink>(() => new Drink());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Drink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DrinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Drink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Drink(Drink other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      Category = other.category_ != null ? other.Category.Clone() : null;
      properties_ = other.properties_.Clone();
      imageUrls_ = other.imageUrls_.Clone();
      description_ = other.description_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Drink Clone() {
      return new Drink(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private global::prodrink.catalog.Category category_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::prodrink.catalog.Category Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::prodrink.catalog.Property> _repeated_properties_codec
        = pb::FieldCodec.ForMessage(34, global::prodrink.catalog.Property.Parser);
    private readonly pbc::RepeatedField<global::prodrink.catalog.Property> properties_ = new pbc::RepeatedField<global::prodrink.catalog.Property>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::prodrink.catalog.Property> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "image_urls" field.</summary>
    public const int ImageUrlsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_imageUrls_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> imageUrls_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ImageUrls {
      get { return imageUrls_; }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Drink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Drink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(Category, other.Category)) return false;
      if(!properties_.Equals(other.properties_)) return false;
      if(!imageUrls_.Equals(other.imageUrls_)) return false;
      if (Description != other.Description) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (category_ != null) hash ^= Category.GetHashCode();
      hash ^= properties_.GetHashCode();
      hash ^= imageUrls_.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (category_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Category);
      }
      properties_.WriteTo(output, _repeated_properties_codec);
      imageUrls_.WriteTo(output, _repeated_imageUrls_codec);
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (category_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Category);
      }
      size += properties_.CalculateSize(_repeated_properties_codec);
      size += imageUrls_.CalculateSize(_repeated_imageUrls_codec);
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Drink other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.category_ != null) {
        if (category_ == null) {
          category_ = new global::prodrink.catalog.Category();
        }
        Category.MergeFrom(other.Category);
      }
      properties_.Add(other.properties_);
      imageUrls_.Add(other.imageUrls_);
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            if (category_ == null) {
              category_ = new global::prodrink.catalog.Category();
            }
            input.ReadMessage(category_);
            break;
          }
          case 34: {
            properties_.AddEntriesFrom(input, _repeated_properties_codec);
            break;
          }
          case 42: {
            imageUrls_.AddEntriesFrom(input, _repeated_imageUrls_codec);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Category : pb::IMessage<Category> {
    private static readonly pb::MessageParser<Category> _parser = new pb::MessageParser<Category>(() => new Category());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Category> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DrinkReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Category() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Category(Category other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      ParentCategory = other.parentCategory_ != null ? other.ParentCategory.Clone() : null;
      propertyTypes_ = other.propertyTypes_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Category Clone() {
      return new Category(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent_category" field.</summary>
    public const int ParentCategoryFieldNumber = 3;
    private global::prodrink.catalog.Category parentCategory_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::prodrink.catalog.Category ParentCategory {
      get { return parentCategory_; }
      set {
        parentCategory_ = value;
      }
    }

    /// <summary>Field number for the "property_types" field.</summary>
    public const int PropertyTypesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::prodrink.catalog.PropertyType> _repeated_propertyTypes_codec
        = pb::FieldCodec.ForMessage(34, global::prodrink.catalog.PropertyType.Parser);
    private readonly pbc::RepeatedField<global::prodrink.catalog.PropertyType> propertyTypes_ = new pbc::RepeatedField<global::prodrink.catalog.PropertyType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::prodrink.catalog.PropertyType> PropertyTypes {
      get { return propertyTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Category);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Category other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(ParentCategory, other.ParentCategory)) return false;
      if(!propertyTypes_.Equals(other.propertyTypes_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (parentCategory_ != null) hash ^= ParentCategory.GetHashCode();
      hash ^= propertyTypes_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (parentCategory_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ParentCategory);
      }
      propertyTypes_.WriteTo(output, _repeated_propertyTypes_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (parentCategory_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ParentCategory);
      }
      size += propertyTypes_.CalculateSize(_repeated_propertyTypes_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Category other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.parentCategory_ != null) {
        if (parentCategory_ == null) {
          parentCategory_ = new global::prodrink.catalog.Category();
        }
        ParentCategory.MergeFrom(other.ParentCategory);
      }
      propertyTypes_.Add(other.propertyTypes_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            if (parentCategory_ == null) {
              parentCategory_ = new global::prodrink.catalog.Category();
            }
            input.ReadMessage(parentCategory_);
            break;
          }
          case 34: {
            propertyTypes_.AddEntriesFrom(input, _repeated_propertyTypes_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PropertyType : pb::IMessage<PropertyType> {
    private static readonly pb::MessageParser<PropertyType> _parser = new pb::MessageParser<PropertyType>(() => new PropertyType());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PropertyType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DrinkReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyType(PropertyType other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      type_ = other.type_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyType Clone() {
      return new PropertyType(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::prodrink.catalog.ValueType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::prodrink.catalog.ValueType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PropertyType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PropertyType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PropertyType other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            type_ = (global::prodrink.catalog.ValueType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Property : pb::IMessage<Property> {
    private static readonly pb::MessageParser<Property> _parser = new pb::MessageParser<Property>(() => new Property());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Property> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::prodrink.catalog.DrinkReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Property() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Property(Property other) : this() {
      id_ = other.id_;
      PropertyType = other.propertyType_ != null ? other.PropertyType.Clone() : null;
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Property Clone() {
      return new Property(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "propertyType" field.</summary>
    public const int PropertyTypeFieldNumber = 2;
    private global::prodrink.catalog.PropertyType propertyType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::prodrink.catalog.PropertyType PropertyType {
      get { return propertyType_; }
      set {
        propertyType_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 3;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Property);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Property other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(PropertyType, other.PropertyType)) return false;
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (propertyType_ != null) hash ^= PropertyType.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (propertyType_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PropertyType);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (propertyType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PropertyType);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Property other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.propertyType_ != null) {
        if (propertyType_ == null) {
          propertyType_ = new global::prodrink.catalog.PropertyType();
        }
        PropertyType.MergeFrom(other.PropertyType);
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            if (propertyType_ == null) {
              propertyType_ = new global::prodrink.catalog.PropertyType();
            }
            input.ReadMessage(propertyType_);
            break;
          }
          case 26: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

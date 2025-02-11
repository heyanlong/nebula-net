/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Meta
{

  public partial class ColumnDef : TBase
  {
    private byte[] _default_value;
    private bool _nullable;
    private byte[] _comment;

    public byte[] Name { get; set; }

    public global::Nebula.Meta.ColumnTypeDef Type { get; set; }

    public byte[] Default_value
    {
      get
      {
        return _default_value;
      }
      set
      {
        __isset.default_value = true;
        this._default_value = value;
      }
    }

    public bool Nullable
    {
      get
      {
        return _nullable;
      }
      set
      {
        __isset.nullable = true;
        this._nullable = value;
      }
    }

    public byte[] Comment
    {
      get
      {
        return _comment;
      }
      set
      {
        __isset.comment = true;
        this._comment = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool default_value;
      public bool nullable;
      public bool comment;
    }

    public ColumnDef()
    {
      this._nullable = false;
      this.__isset.nullable = true;
    }

    public ColumnDef(byte[] name, global::Nebula.Meta.ColumnTypeDef type) : this()
    {
      this.Name = name;
      this.Type = type;
    }

    public ColumnDef DeepCopy()
    {
      var tmp10 = new ColumnDef();
      if((Name != null))
      {
        tmp10.Name = this.Name.ToArray();
      }
      if((Type != null))
      {
        tmp10.Type = (global::Nebula.Meta.ColumnTypeDef)this.Type.DeepCopy();
      }
      if((Default_value != null) && __isset.default_value)
      {
        tmp10.Default_value = this.Default_value.ToArray();
      }
      tmp10.__isset.default_value = this.__isset.default_value;
      if(__isset.nullable)
      {
        tmp10.Nullable = this.Nullable;
      }
      tmp10.__isset.nullable = this.__isset.nullable;
      if((Comment != null) && __isset.comment)
      {
        tmp10.Comment = this.Comment.ToArray();
      }
      tmp10.__isset.comment = this.__isset.comment;
      return tmp10;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_name = false;
        bool isset_type = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadBinaryAsync(cancellationToken);
                isset_name = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Type = new global::Nebula.Meta.ColumnTypeDef();
                await Type.ReadAsync(iprot, cancellationToken);
                isset_type = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Default_value = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                Nullable = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                Comment = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_name)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_type)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp11 = new TStruct("ColumnDef");
        await oprot.WriteStructBeginAsync(tmp11, cancellationToken);
        var tmp12 = new TField();
        if((Name != null))
        {
          tmp12.Name = "name";
          tmp12.Type = TType.String;
          tmp12.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteBinaryAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Type != null))
        {
          tmp12.Name = "type";
          tmp12.Type = TType.Struct;
          tmp12.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await Type.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Default_value != null) && __isset.default_value)
        {
          tmp12.Name = "default_value";
          tmp12.Type = TType.String;
          tmp12.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteBinaryAsync(Default_value, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.nullable)
        {
          tmp12.Name = "nullable";
          tmp12.Type = TType.Bool;
          tmp12.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteBoolAsync(Nullable, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Comment != null) && __isset.comment)
        {
          tmp12.Name = "comment";
          tmp12.Type = TType.String;
          tmp12.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteBinaryAsync(Comment, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is ColumnDef other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Name, other.Name)
        && System.Object.Equals(Type, other.Type)
        && ((__isset.default_value == other.__isset.default_value) && ((!__isset.default_value) || (TCollections.Equals(Default_value, other.Default_value))))
        && ((__isset.nullable == other.__isset.nullable) && ((!__isset.nullable) || (System.Object.Equals(Nullable, other.Nullable))))
        && ((__isset.comment == other.__isset.comment) && ((!__isset.comment) || (TCollections.Equals(Comment, other.Comment))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Name != null))
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if((Type != null))
        {
          hashcode = (hashcode * 397) + Type.GetHashCode();
        }
        if((Default_value != null) && __isset.default_value)
        {
          hashcode = (hashcode * 397) + Default_value.GetHashCode();
        }
        if(__isset.nullable)
        {
          hashcode = (hashcode * 397) + Nullable.GetHashCode();
        }
        if((Comment != null) && __isset.comment)
        {
          hashcode = (hashcode * 397) + Comment.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp13 = new StringBuilder("ColumnDef(");
      if((Name != null))
      {
        tmp13.Append(", Name: ");
        Name.ToString(tmp13);
      }
      if((Type != null))
      {
        tmp13.Append(", Type: ");
        Type.ToString(tmp13);
      }
      if((Default_value != null) && __isset.default_value)
      {
        tmp13.Append(", Default_value: ");
        Default_value.ToString(tmp13);
      }
      if(__isset.nullable)
      {
        tmp13.Append(", Nullable: ");
        Nullable.ToString(tmp13);
      }
      if((Comment != null) && __isset.comment)
      {
        tmp13.Append(", Comment: ");
        Comment.ToString(tmp13);
      }
      tmp13.Append(')');
      return tmp13.ToString();
    }
  }

}

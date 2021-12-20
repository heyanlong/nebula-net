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

  public partial class AlterSchemaItem : TBase
  {
    private global::Nebula.Meta.AlterSchemaOp _op;
    private global::Nebula.Meta.Schema _schema;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Meta.AlterSchemaOp"/>
    /// </summary>
    public global::Nebula.Meta.AlterSchemaOp Op
    {
      get
      {
        return _op;
      }
      set
      {
        __isset.op = true;
        this._op = value;
      }
    }

    public global::Nebula.Meta.Schema Schema
    {
      get
      {
        return _schema;
      }
      set
      {
        __isset.schema = true;
        this._schema = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool op;
      public bool schema;
    }

    public AlterSchemaItem()
    {
    }

    public AlterSchemaItem DeepCopy()
    {
      var tmp49 = new AlterSchemaItem();
      if(__isset.op)
      {
        tmp49.Op = this.Op;
      }
      tmp49.__isset.op = this.__isset.op;
      if((Schema != null) && __isset.schema)
      {
        tmp49.Schema = (global::Nebula.Meta.Schema)this.Schema.DeepCopy();
      }
      tmp49.__isset.schema = this.__isset.schema;
      return tmp49;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
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
              if (field.Type == TType.I32)
              {
                Op = (global::Nebula.Meta.AlterSchemaOp)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Schema = new global::Nebula.Meta.Schema();
                await Schema.ReadAsync(iprot, cancellationToken);
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
        var tmp50 = new TStruct("AlterSchemaItem");
        await oprot.WriteStructBeginAsync(tmp50, cancellationToken);
        var tmp51 = new TField();
        if(__isset.op)
        {
          tmp51.Name = "op";
          tmp51.Type = TType.I32;
          tmp51.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp51, cancellationToken);
          await oprot.WriteI32Async((int)Op, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Schema != null) && __isset.schema)
        {
          tmp51.Name = "schema";
          tmp51.Type = TType.Struct;
          tmp51.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp51, cancellationToken);
          await Schema.WriteAsync(oprot, cancellationToken);
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
      if (!(that is AlterSchemaItem other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.op == other.__isset.op) && ((!__isset.op) || (System.Object.Equals(Op, other.Op))))
        && ((__isset.schema == other.__isset.schema) && ((!__isset.schema) || (System.Object.Equals(Schema, other.Schema))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.op)
        {
          hashcode = (hashcode * 397) + Op.GetHashCode();
        }
        if((Schema != null) && __isset.schema)
        {
          hashcode = (hashcode * 397) + Schema.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp52 = new StringBuilder("AlterSchemaItem(");
      int tmp53 = 0;
      if(__isset.op)
      {
        if(0 < tmp53++) { tmp52.Append(", "); }
        tmp52.Append("Op: ");
        Op.ToString(tmp52);
      }
      if((Schema != null) && __isset.schema)
      {
        if(0 < tmp53++) { tmp52.Append(", "); }
        tmp52.Append("Schema: ");
        Schema.ToString(tmp52);
      }
      tmp52.Append(')');
      return tmp52.ToString();
    }
  }

}

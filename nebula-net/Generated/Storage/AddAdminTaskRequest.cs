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

namespace Nebula.Storage
{

  public partial class AddAdminTaskRequest : TBase
  {
    private global::Nebula.Meta.AdminCmd _cmd;
    private int _job_id;
    private int _task_id;
    private global::Nebula.Storage.TaskPara _para;
    private int _concurrency;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Meta.AdminCmd"/>
    /// </summary>
    public global::Nebula.Meta.AdminCmd Cmd
    {
      get
      {
        return _cmd;
      }
      set
      {
        __isset.cmd = true;
        this._cmd = value;
      }
    }

    public int Job_id
    {
      get
      {
        return _job_id;
      }
      set
      {
        __isset.job_id = true;
        this._job_id = value;
      }
    }

    public int Task_id
    {
      get
      {
        return _task_id;
      }
      set
      {
        __isset.task_id = true;
        this._task_id = value;
      }
    }

    public global::Nebula.Storage.TaskPara Para
    {
      get
      {
        return _para;
      }
      set
      {
        __isset.para = true;
        this._para = value;
      }
    }

    public int Concurrency
    {
      get
      {
        return _concurrency;
      }
      set
      {
        __isset.concurrency = true;
        this._concurrency = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool cmd;
      public bool job_id;
      public bool task_id;
      public bool para;
      public bool concurrency;
    }

    public AddAdminTaskRequest()
    {
    }

    public AddAdminTaskRequest DeepCopy()
    {
      var tmp402 = new AddAdminTaskRequest();
      if(__isset.cmd)
      {
        tmp402.Cmd = this.Cmd;
      }
      tmp402.__isset.cmd = this.__isset.cmd;
      if(__isset.job_id)
      {
        tmp402.Job_id = this.Job_id;
      }
      tmp402.__isset.job_id = this.__isset.job_id;
      if(__isset.task_id)
      {
        tmp402.Task_id = this.Task_id;
      }
      tmp402.__isset.task_id = this.__isset.task_id;
      if((Para != null) && __isset.para)
      {
        tmp402.Para = (global::Nebula.Storage.TaskPara)this.Para.DeepCopy();
      }
      tmp402.__isset.para = this.__isset.para;
      if(__isset.concurrency)
      {
        tmp402.Concurrency = this.Concurrency;
      }
      tmp402.__isset.concurrency = this.__isset.concurrency;
      return tmp402;
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
                Cmd = (global::Nebula.Meta.AdminCmd)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Job_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Task_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                Para = new global::Nebula.Storage.TaskPara();
                await Para.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                Concurrency = await iprot.ReadI32Async(cancellationToken);
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
        var tmp403 = new TStruct("AddAdminTaskRequest");
        await oprot.WriteStructBeginAsync(tmp403, cancellationToken);
        var tmp404 = new TField();
        if(__isset.cmd)
        {
          tmp404.Name = "cmd";
          tmp404.Type = TType.I32;
          tmp404.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp404, cancellationToken);
          await oprot.WriteI32Async((int)Cmd, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.job_id)
        {
          tmp404.Name = "job_id";
          tmp404.Type = TType.I32;
          tmp404.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp404, cancellationToken);
          await oprot.WriteI32Async(Job_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.task_id)
        {
          tmp404.Name = "task_id";
          tmp404.Type = TType.I32;
          tmp404.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp404, cancellationToken);
          await oprot.WriteI32Async(Task_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Para != null) && __isset.para)
        {
          tmp404.Name = "para";
          tmp404.Type = TType.Struct;
          tmp404.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp404, cancellationToken);
          await Para.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.concurrency)
        {
          tmp404.Name = "concurrency";
          tmp404.Type = TType.I32;
          tmp404.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp404, cancellationToken);
          await oprot.WriteI32Async(Concurrency, cancellationToken);
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
      if (!(that is AddAdminTaskRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.cmd == other.__isset.cmd) && ((!__isset.cmd) || (System.Object.Equals(Cmd, other.Cmd))))
        && ((__isset.job_id == other.__isset.job_id) && ((!__isset.job_id) || (System.Object.Equals(Job_id, other.Job_id))))
        && ((__isset.task_id == other.__isset.task_id) && ((!__isset.task_id) || (System.Object.Equals(Task_id, other.Task_id))))
        && ((__isset.para == other.__isset.para) && ((!__isset.para) || (System.Object.Equals(Para, other.Para))))
        && ((__isset.concurrency == other.__isset.concurrency) && ((!__isset.concurrency) || (System.Object.Equals(Concurrency, other.Concurrency))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.cmd)
        {
          hashcode = (hashcode * 397) + Cmd.GetHashCode();
        }
        if(__isset.job_id)
        {
          hashcode = (hashcode * 397) + Job_id.GetHashCode();
        }
        if(__isset.task_id)
        {
          hashcode = (hashcode * 397) + Task_id.GetHashCode();
        }
        if((Para != null) && __isset.para)
        {
          hashcode = (hashcode * 397) + Para.GetHashCode();
        }
        if(__isset.concurrency)
        {
          hashcode = (hashcode * 397) + Concurrency.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp405 = new StringBuilder("AddAdminTaskRequest(");
      int tmp406 = 0;
      if(__isset.cmd)
      {
        if(0 < tmp406++) { tmp405.Append(", "); }
        tmp405.Append("Cmd: ");
        Cmd.ToString(tmp405);
      }
      if(__isset.job_id)
      {
        if(0 < tmp406++) { tmp405.Append(", "); }
        tmp405.Append("Job_id: ");
        Job_id.ToString(tmp405);
      }
      if(__isset.task_id)
      {
        if(0 < tmp406++) { tmp405.Append(", "); }
        tmp405.Append("Task_id: ");
        Task_id.ToString(tmp405);
      }
      if((Para != null) && __isset.para)
      {
        if(0 < tmp406++) { tmp405.Append(", "); }
        tmp405.Append("Para: ");
        Para.ToString(tmp405);
      }
      if(__isset.concurrency)
      {
        if(0 < tmp406++) { tmp405.Append(", "); }
        tmp405.Append("Concurrency: ");
        Concurrency.ToString(tmp405);
      }
      tmp405.Append(')');
      return tmp405.ToString();
    }
  }

}

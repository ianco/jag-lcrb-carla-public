﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gov.Lclb.Cllb.Public.Contexts.Microsoft.Dynamics.CRM;
using Gov.Lclb.Cllb.Public.ViewModels;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class Adoxio_LegalEntityExtensions
    {


        /// <summary>
        /// Copy values from a Dynamics legal entity to another one
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void CopyValues(this Adoxio_legalentity to, Adoxio_legalentity from)
        {
            to.Adoxio_legalentityid = from.Adoxio_legalentityid;
            to.Adoxio_commonnonvotingshares = from.Adoxio_commonnonvotingshares;
            to.Adoxio_commonvotingshares = from.Adoxio_commonvotingshares;
            to.Adoxio_dateofbirth = from.Adoxio_dateofbirth;
            to.Adoxio_firstname = from.Adoxio_firstname;
            to.Adoxio_interestpercentage = from.Adoxio_interestpercentage;
            to.Adoxio_isindividual = from.Adoxio_isindividual;
            to.Adoxio_lastname = from.Adoxio_lastname;
            to.Adoxio_legalentitytype = from.Adoxio_legalentitytype;
            to.Adoxio_middlename = from.Adoxio_middlename;
            to.Adoxio_name = from.Adoxio_name;
            to.Adoxio_position = from.Adoxio_position;
            to.Adoxio_preferrednonvotingshares = from.Adoxio_preferrednonvotingshares;
            to.Adoxio_preferredvotingshares = from.Adoxio_preferredvotingshares;
            to.Adoxio_sameasapplyingperson = from.Adoxio_sameasapplyingperson;
        }

        /// <summary>
        /// Copy values from a Dynamics legal entity to a view model.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void CopyValues(this Adoxio_legalentity to, ViewModels.AdoxioLegalEntity from)
        {
            to.Adoxio_legalentityid = new Guid(from.id);
            to.Adoxio_commonnonvotingshares = from.commonnonvotingshares;
            to.Adoxio_commonvotingshares = from.commonvotingshares;
            to.Adoxio_dateofbirth = from.dateofbirth;
            to.Adoxio_firstname = from.firstname;
            to.Adoxio_interestpercentage = from.interestpercentage;
            to.Adoxio_isindividual = (from.isindividual != null && (bool)from.isindividual) ? 1 : 0;
            to.Adoxio_lastname = from.lastname;
            to.Adoxio_legalentitytype = (int?)from.legalentitytype;
            to.Adoxio_middlename = from.middlename;
            to.Adoxio_name = from.name;
            to.Adoxio_position = (int?)from.position;
            to.Adoxio_preferrednonvotingshares = from.preferrednonvotingshares;
            to.Adoxio_preferredvotingshares = from.preferredvotingshares;
            to.Adoxio_sameasapplyingperson = (from.sameasapplyingperson != null && (bool)from.sameasapplyingperson) ? 1 : 0;
        }

        /// <summary>
        /// Convert a given voteQuestion to a ViewModel
        /// </summary>        
        public static ViewModels.AdoxioLegalEntity ToViewModel(this Adoxio_legalentity adoxio_legalentity)
        {
            ViewModels.AdoxioLegalEntity result = null;
            if (adoxio_legalentity != null)
            {
                result = new ViewModels.AdoxioLegalEntity();
                if (adoxio_legalentity.Adoxio_legalentityid != null)
                {
                    result.id = adoxio_legalentity.Adoxio_legalentityid.ToString();
                }
                
                result.commonnonvotingshares = adoxio_legalentity.Adoxio_commonnonvotingshares;
                result.commonvotingshares = adoxio_legalentity.Adoxio_commonvotingshares;
                result.dateofbirth = adoxio_legalentity.Adoxio_dateofbirth;
                result.firstname = adoxio_legalentity.Adoxio_firstname;
                result.interestpercentage = adoxio_legalentity.Adoxio_interestpercentage;
                // convert from int to bool.
                result.isindividual = (adoxio_legalentity.Adoxio_isindividual != null && adoxio_legalentity.Adoxio_isindividual != 0);
                result.lastname = adoxio_legalentity.Adoxio_lastname;
                if (adoxio_legalentity.Adoxio_legalentitytype != null)
                {
                    result.legalentitytype = (Adoxio_applicanttypecodes)adoxio_legalentity.Adoxio_legalentitytype;
                }
                
                result.middlename = adoxio_legalentity.Adoxio_middlename;
                result.name = adoxio_legalentity.Adoxio_name;
                if (adoxio_legalentity.Adoxio_position != null)
                {
                    result.position = (PositionOptions)adoxio_legalentity.Adoxio_position;
                }
                
                result.preferrednonvotingshares = adoxio_legalentity.Adoxio_preferrednonvotingshares;
                result.preferredvotingshares = adoxio_legalentity.Adoxio_preferredvotingshares;
                // convert from int to bool.
                result.sameasapplyingperson = (adoxio_legalentity.Adoxio_sameasapplyingperson != null && adoxio_legalentity.Adoxio_sameasapplyingperson != 0);

                // populate the account.
                if (adoxio_legalentity.Adoxio_Account != null)
                {
                    result.account = adoxio_legalentity.Adoxio_Account.ToViewModel();
                }
                
            }            
            return result;
        }

        /// <summary>
        /// Convert a legal entity to a model
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public static Adoxio_legalentity ToModel(this ViewModels.AdoxioLegalEntity from)
        {
            Adoxio_legalentity result = null;
            if (from != null)
            {
                result = new Adoxio_legalentity();
                
                result.Adoxio_legalentityid = new Guid(from.id);
                result.Adoxio_commonnonvotingshares = from.commonnonvotingshares;
                result.Adoxio_commonvotingshares = from.commonvotingshares;
                result.Adoxio_dateofbirth = from.dateofbirth;
                result.Adoxio_firstname = from.firstname;
                result.Adoxio_interestpercentage = from.interestpercentage;
                result.Adoxio_isindividual = (from.isindividual != null && (bool)from.isindividual) ? 1 : 0; 
                result.Adoxio_lastname = from.lastname;
                result.Adoxio_legalentitytype = (int?) from.legalentitytype;
                result.Adoxio_middlename = from.middlename;
                result.Adoxio_name = from.name;
                result.Adoxio_position = (int?) from.position;
                result.Adoxio_preferrednonvotingshares = from.preferrednonvotingshares;
                result.Adoxio_preferredvotingshares = from.preferredvotingshares;
                result.Adoxio_sameasapplyingperson = (from.sameasapplyingperson != null && (bool)from.sameasapplyingperson) ? 1 : 0;
            }
            return result;
        }
    }
}
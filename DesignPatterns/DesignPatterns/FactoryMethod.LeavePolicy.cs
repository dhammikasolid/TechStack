using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    // Dependencies

        // DTO
    public interface LeaveRequest
    {

    }
        // Injected Dependency
    public interface LeaveService
    {

    }

    // Product
    public abstract class LeaveRule
    {
        public abstract bool CheckEligibility(LeaveRequest  leaveRequest, LeaveService leaveService);

        public abstract string GetFailingMessage();
    }

    // Concrete Product
    public class NConsecutiveLeaves : LeaveRule
    {
        public override bool CheckEligibility(LeaveRequest leaveRequest, LeaveService leaveService)
        {
            return true;
        }

        public override string GetFailingMessage()
        {
            return "NConsecutiveLeaves Failed";
        }
    }

    // Concrete Product
    public class NDaysToLastLeave : LeaveRule
    {
        public override bool CheckEligibility(LeaveRequest leaveRequest, LeaveService leaveService)
        {
            return true;
        }

        public override string GetFailingMessage()
        {
            return "NDaysToLastLeave Failed";
        }
    }

    // Creator
    public abstract class LeavePolicy
    {
        protected IList<LeaveRule> rules = new List<LeaveRule>();

        public bool CheckEligibility(LeaveRequest leaveRequest, LeaveService leaveService)
        {
            foreach (var rule in rules)
            {
                if (!rule.CheckEligibility(leaveRequest, leaveService))
                    return false;
            }

            return true;
        }

        public abstract void AddRules();
    }

    // Concrete Creator
    public class LeaveAssignmentPolicy: LeavePolicy
    {
        public override void AddRules()
        {
            rules.Add(new NConsecutiveLeaves());
        }
    }

    public class LeaveRequestPolicy : LeavePolicy
    {
        public override void AddRules()
        {
            rules.Add(new NConsecutiveLeaves());
            rules.Add(new NDaysToLastLeave());
        }
    }

    // Factory Method 2nd form
    //Concentrate Creator with Factory Method
    public class LeavePolicyManager
    {
        public LeavePolicy GetLeavePolicy(string type, LeaveRequest leaveRequest, LeaveService leaveService)
        {
            if (type == "Assignment")
                return new LeaveAssignmentPolicy();
            else if (type == "Request")
                return new LeaveRequestPolicy();

            return null;
        }
    }
}

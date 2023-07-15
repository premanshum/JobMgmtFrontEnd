# JobManagementWeb

## Web interface for Job management project

Business flow:

ACME Sales and Repairs want to implement a ticket resolving system. A Ticket can be either a new connection or repair an existing connection.

A user calls the call-center to raise a ticket. The ticket is then assigned to backend engineers by their supervisor.
Engineers can update the status of the ticket like Accepted, On the way, work in progress, rejected, completed etc.
Once completed or rejected, the ticket is removed from engineer's queue.
Below are the business flows:

1.  A call center employee will be the one to create the tickets. Data collected will be Name, address with pin, mobile number and email.
2.  A ticket can be of only be of two flavor, New or Repair.
3.  There cannot be 2 Tickets with the same phone number. If the same customer calls, the old ticket has to be closed and then only new one can be created.
4.  Call center guy should have facility to search for ticket by Name, mobile number, email or ticket number.
5.  If a ticket is found, it should have the work update along with date and time.
6.  System should not allow additional ticket on the same mobile number, if the existing one is not closed.
7.  Only a call-center guy can close the ticket, by calling the customer on their mobile number.
8.  Call-center guy should have facility to see the tickets which are not yet closed.
9.  Every engineer should belong to a team, headed by a supervisor.
10. New joinee engineers belong to free pool team.
11. Supervisor can see the list of engineers assigned to him. He cannot rename , modify or delete a team.
12. Supervisor can assign non-closed or rejecetd tickets to engineers. He should have a facility to see available tickets.
13. Supervisor should have facility to filter the tickets to see the open, non-closed tickets. Closed tickets may not be shown.
14. Admin is the person who can create, rename, delete or modify a Team.
15. Admin can shuffle the engineers, supervisors from one team to another.
16. Admin should have facility to see engineers (assigned/unassigned), team details etc. He should be able to filter the list.
17. Engineers can have 5 tickets in a queue in a day. They can reject one ticket per day. This has to be configurable by admin.
18. Engineers should be able to update the status of the ticket to Accepted, Rejected, On the way, work in progress and completed.
19. Supervisor should be able to search a ticket by Mobile number, Name, ticket number.
20. Supervisor should be able to see all the engineers under his team and filter by engineer or work status.
21. Supervisor should not see the other teams. He can search a ticket that belongs to other teams.

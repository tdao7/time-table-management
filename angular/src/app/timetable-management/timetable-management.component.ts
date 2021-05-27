import { Component, OnInit } from '@angular/core';
import {ApiService} from "../services/api.service";
import {MatDialog, MatDialogConfig} from "@angular/material/dialog";
import {AddScheduleComponent} from "./dialogs/add-schedule/add-schedule.component";
import {FormControl, FormGroup} from "@angular/forms";
import {AddTimetableComponent} from "./dialogs/add-timetable/add-timetable.component";

@Component({
  selector: 'app-timetable-management',
  templateUrl: './timetable-management.component.html',
  styleUrls: ['./timetable-management.component.css']
})
export class TimetableManagementComponent implements OnInit {

  users;
  faculties;
  classrooms;
  rooms;
  subjects;
  schedules;
  teachers;

  targetFaculty;
  searchForm: FormGroup;

  constructor(
      private apiServices: ApiService,
      private dialog: MatDialog,
  ) { }

  ngOnInit(): void {
    this.searchForm = new FormGroup({
      facultyId: new FormControl('')
    })

    this.getAllUser();
    this.getAllFaculty();
    this.getAllRoom();
    this.getAllClassrooms();
    this.getAllSubject();
    this.getAllSchedule();
    this.GetAllTeacher();
  }

  getAllUser() {
    this.apiServices.getAllUser().subscribe(data => {
      this.users = data;
    })
  }

  getAllFaculty() {
    this.apiServices.getFacultys().subscribe(data => {
      this.faculties = data;
      this.targetFaculty  = data[0]?.id;
      this.searchForm.controls.facultyId = this.targetFaculty;
    })
  }

  getAllRoom() {
    this.apiServices.getRooms().subscribe(data => {
      this.rooms = data;
    })
  }

  getAllClassrooms() {
    this.apiServices.getClassrooms().subscribe(data => {
      this.classrooms = data;
    })
  }

  getAllSubject() {
    this.apiServices.getSubject().subscribe(data => {
      this.subjects = data;
    })
  }

  getAllSchedule() {
    this.apiServices.getSchedule().subscribe(data => {
      this.schedules = data;
    })
  }

  openAddScheduleDialog() {
    const config: MatDialogConfig = {
      panelClass: "dialog-responsive-30",
      data: {
        classrooms: this.classrooms,
        rooms: this.rooms,
        faculties: this.faculties,
        targetFaculty: this.targetFaculty
      },
      minWidth: '500px',
    }
    this.dialog.open(AddScheduleComponent, config).afterClosed().subscribe(result => {
      if (result) {
        this.getAllSchedule();
      }
    });
  }

  openAddTimetableDialog(schedule: any, index: number) {
    const config: MatDialogConfig = {
      panelClass: "dialog-responsive-30",
      data: {
        classrooms: this.classrooms,
        subjects: this.subjects,
        teachers: this.teachers,
        scheduleId: schedule?.id,
        dayIndex: index
      },
      minWidth: '500px',
    }
    this.dialog.open(AddTimetableComponent, config).afterClosed().subscribe(result => {
      if (result) {
        this.getAllSchedule();
      }
    });
  }

  private GetAllTeacher() {
    this.apiServices.getTeachers().subscribe(data => {
      this.teachers = data;
    })
  }
}

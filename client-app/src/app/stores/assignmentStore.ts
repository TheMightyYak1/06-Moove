import { makeAutoObservable } from "mobx";

export default class AssignmentStore {
    
    constructor () {
        makeAutoObservable(this);

    }

    loadAssignments = async () => {

    }

    loadAssignment = async () => {
        
    }

}